﻿// --------------------------------
// <copyright file="JsonQueryStringHelper.cs" company="Thuzi, LLC">
//     Copyright (c) 2010 Thuzi, LLC (thuzi.com)
// </copyright>
// <author>Nathan Totten (ntotten.com) and Jim Zimmerman (jimzimmerman.com)</author>
// <license>Released under the terms of the Microsoft Public License (Ms-PL)</license>
// <website>http://facebooksdk.codeplex.com</website>
// ---------------------------------

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Facebook.Utilities
{
    /// <summary>
    /// Extension methods to turn Dictionary type collections
    /// into Json formatted query strings.
    /// </summary>
    internal static class JsonQueryStringHelper
    {

        /// <summary>
        /// Converts the dictionary to a json formatted query string.
        /// </summary>
        /// <param name="dictionary">The dictionary.</param>
        /// <returns>A Json formatted querystring.</returns>
        public static string ToJsonQueryString(this IDictionary<string, string> dictionary)
        {
            if (dictionary == null)
            {
                throw new ArgumentNullException("dictionary");
            }
            Contract.Ensures(Contract.Result<string>() != null);
            Contract.EndContractBlock();

            StringBuilder sb = new StringBuilder();
            bool isFirst = true;
            foreach (var key in dictionary.Keys)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    sb.Append("&");
                }
                if (!string.IsNullOrEmpty(dictionary[key]))
                {
                    // Just to make sure 
                    string value = dictionary[key].Replace(", ", ",");

                    // Format Object As Json And Remove leading and trailing perenthesis
                    string jsonValue = JsonSerializer.SerializeObject(value);
                    if (jsonValue.StartsWith("\""))
                    {
                        jsonValue = jsonValue.Substring(1, jsonValue.Length - 1);
                    }
                    if (jsonValue.EndsWith("\""))
                    {
                        jsonValue = jsonValue.Substring(0, jsonValue.Length - 1);
                    }
                    sb.AppendFormat("{0}={1}", key, Uri.EscapeUriString(jsonValue));
                }
                else
                {
                    sb.Append(key);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Converts the dictionary to a json formatted query string.
        /// </summary>
        /// <param name="dictionary">The dictionary.</param>
        /// <returns>A Json formatted querystring.</returns>
        public static string ToJsonQueryString(this IDictionary<string, object> dictionary)
        {
            if (dictionary == null)
            {
                throw new ArgumentNullException("dictionary");
            }
            Contract.Ensures(Contract.Result<string>() != null);
            Contract.EndContractBlock();

            return ToJsonQueryString(dictionary.ToDictionary(d => d.Key, d => (d.Value == null ? string.Empty : d.Value.ToString())));
        }

#if !SILVERLIGHT


        /// <summary>
        /// Converts the NameValueCollection to a json formatted query string.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <returns>A Json formatted querystring.</returns>
        public static string ToJsonQueryString(this NameValueCollection collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection");
            }
            Contract.Ensures(Contract.Result<string>() != null);
            Contract.EndContractBlock();

            var dictionary = new Dictionary<string, string>();
            collection.AllKeys.ToList().ForEach((key) =>
            {
                if (key != null)
                {
                    dictionary.Add(key, collection[key]);
                }
            });
            return ToJsonQueryString(dictionary);
        }
#endif

    }
}
