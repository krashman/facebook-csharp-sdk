﻿ 
// <autogenerated>
//   This file was generated using AutoMapperSetup.tt.
//   Any changes made manually will be lost next time the file is regenerated.
// </autogenerated>
using System;
using System.Collections.Generic;
using AutoMapper;

namespace Facebook.Api {
	
	public static partial class AutoMapperSetup {
	
		public static void Initialize() {
		
			// FQL Objects

			var fqlSchemaToModel = Mapper.CreateProfile("facebook_fql_schema_to_model");
            fqlSchemaToModel.SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
            fqlSchemaToModel.DestinationMemberNamingConvention = new PascalCaseNamingConvention();
			
			var fqlModelToSchema = Mapper.CreateProfile("facebook_fql_model_to_schema");
            fqlModelToSchema.SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
            fqlModelToSchema.DestinationMemberNamingConvention = new PascalCaseNamingConvention();
			
			// Fql Album Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Album, Facebook.Models.Fql.Album>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Album, Facebook.Schema.Fql.Album>();
			
			// Fql Application Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Application, Facebook.Models.Fql.Application>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Application, Facebook.Schema.Fql.Application>();
			
			// Fql Comment Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Comment, Facebook.Models.Fql.Comment>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Comment, Facebook.Schema.Fql.Comment>();
			
			// Fql Connection Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Connection, Facebook.Models.Fql.Connection>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Connection, Facebook.Schema.Fql.Connection>();
			
			// Fql Cookie Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Cookie, Facebook.Models.Fql.Cookie>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Cookie, Facebook.Schema.Fql.Cookie>();
			
			// Fql Developer Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Developer, Facebook.Models.Fql.Developer>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Developer, Facebook.Schema.Fql.Developer>();
			
			// Fql Event Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Event, Facebook.Models.Fql.Event>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Event, Facebook.Schema.Fql.Event>();
			
			// Fql EventMember Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.EventMember, Facebook.Models.Fql.EventMember>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.EventMember, Facebook.Schema.Fql.EventMember>();
			
			// Fql Family Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Family, Facebook.Models.Fql.Family>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Family, Facebook.Schema.Fql.Family>();
			
			// Fql Friend Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Friend, Facebook.Models.Fql.Friend>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Friend, Facebook.Schema.Fql.Friend>();
			
			// Fql Friendlist Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Friendlist, Facebook.Models.Fql.Friendlist>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Friendlist, Facebook.Schema.Fql.Friendlist>();
			
			// Fql FriendlistMember Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.FriendlistMember, Facebook.Models.Fql.FriendlistMember>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.FriendlistMember, Facebook.Schema.Fql.FriendlistMember>();
			
			// Fql FriendRequest Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.FriendRequest, Facebook.Models.Fql.FriendRequest>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.FriendRequest, Facebook.Schema.Fql.FriendRequest>();
			
			// Fql Group Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Group, Facebook.Models.Fql.Group>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Group, Facebook.Schema.Fql.Group>();
			
			// Fql GroupMember Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.GroupMember, Facebook.Models.Fql.GroupMember>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.GroupMember, Facebook.Schema.Fql.GroupMember>();
			
			// Fql Like Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Like, Facebook.Models.Fql.Like>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Like, Facebook.Schema.Fql.Like>();
			
			// Fql Link Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Link, Facebook.Models.Fql.Link>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Link, Facebook.Schema.Fql.Link>();
			
			// Fql LinkStat Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.LinkStat, Facebook.Models.Fql.LinkStat>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.LinkStat, Facebook.Schema.Fql.LinkStat>();
			
			// Fql MailboxFolder Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.MailboxFolder, Facebook.Models.Fql.MailboxFolder>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.MailboxFolder, Facebook.Schema.Fql.MailboxFolder>();
			
			// Fql Message Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Message, Facebook.Models.Fql.Message>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Message, Facebook.Schema.Fql.Message>();
			
			// Fql Metric Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Metric, Facebook.Models.Fql.Metric>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Metric, Facebook.Schema.Fql.Metric>();
			
			// Fql Note Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Note, Facebook.Models.Fql.Note>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Note, Facebook.Schema.Fql.Note>();
			
			// Fql Notification Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Notification, Facebook.Models.Fql.Notification>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Notification, Facebook.Schema.Fql.Notification>();
			
			// Fql ObjectUrl Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.ObjectUrl, Facebook.Models.Fql.ObjectUrl>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.ObjectUrl, Facebook.Schema.Fql.ObjectUrl>();
			
			// Fql Page Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Page, Facebook.Models.Fql.Page>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Page, Facebook.Schema.Fql.Page>();
			
			// Fql PageAdmin Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.PageAdmin, Facebook.Models.Fql.PageAdmin>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.PageAdmin, Facebook.Schema.Fql.PageAdmin>();
			
			// Fql PageFan Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.PageFan, Facebook.Models.Fql.PageFan>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.PageFan, Facebook.Schema.Fql.PageFan>();
			
			// Fql Permission Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Permission, Facebook.Models.Fql.Permission>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Permission, Facebook.Schema.Fql.Permission>();
			
			// Fql PermissionsInfo Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.PermissionsInfo, Facebook.Models.Fql.PermissionsInfo>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.PermissionsInfo, Facebook.Schema.Fql.PermissionsInfo>();
			
			// Fql Photo Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Photo, Facebook.Models.Fql.Photo>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Photo, Facebook.Schema.Fql.Photo>();
			
			// Fql PhotoTag Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.PhotoTag, Facebook.Models.Fql.PhotoTag>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.PhotoTag, Facebook.Schema.Fql.PhotoTag>();
			
			// Fql Privacy Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Privacy, Facebook.Models.Fql.Privacy>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Privacy, Facebook.Schema.Fql.Privacy>();
			
			// Fql Profile Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Profile, Facebook.Models.Fql.Profile>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Profile, Facebook.Schema.Fql.Profile>();
			
			// Fql StandardFriendInfo Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.StandardFriendInfo, Facebook.Models.Fql.StandardFriendInfo>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.StandardFriendInfo, Facebook.Schema.Fql.StandardFriendInfo>();
			
			// Fql StandardUserInfo Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.StandardUserInfo, Facebook.Models.Fql.StandardUserInfo>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.StandardUserInfo, Facebook.Schema.Fql.StandardUserInfo>();
			
			// Fql Status Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Status, Facebook.Models.Fql.Status>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Status, Facebook.Schema.Fql.Status>();
			
			// Fql Stream Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Stream, Facebook.Models.Fql.Stream>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Stream, Facebook.Schema.Fql.Stream>();
			
			// Fql StreamFilter Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.StreamFilter, Facebook.Models.Fql.StreamFilter>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.StreamFilter, Facebook.Schema.Fql.StreamFilter>();
			
			// Fql StreamTag Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.StreamTag, Facebook.Models.Fql.StreamTag>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.StreamTag, Facebook.Schema.Fql.StreamTag>();
			
			// Fql Thread Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Thread, Facebook.Models.Fql.Thread>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Thread, Facebook.Schema.Fql.Thread>();
			
			// Fql Translation Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Translation, Facebook.Models.Fql.Translation>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Translation, Facebook.Schema.Fql.Translation>();
			
			// Fql User Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.User, Facebook.Models.Fql.User>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.User, Facebook.Schema.Fql.User>();
			
			// Fql Video Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.Video, Facebook.Models.Fql.Video>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.Video, Facebook.Schema.Fql.Video>();
			
			// Fql VideoTag Mappings
			fqlSchemaToModel.CreateMap<Facebook.Schema.Fql.VideoTag, Facebook.Models.Fql.VideoTag>();
			fqlModelToSchema.CreateMap<Facebook.Models.Fql.VideoTag, Facebook.Schema.Fql.VideoTag>();
			
			
			// Graph Objects

			var graphSchemaToModel = Mapper.CreateProfile("facebook_fql_schema_to_model");
            graphSchemaToModel.SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
            graphSchemaToModel.DestinationMemberNamingConvention = new PascalCaseNamingConvention();
			
			var graphModelToSchema = Mapper.CreateProfile("facebook_fql_model_to_schema");
            graphModelToSchema.SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
            graphModelToSchema.DestinationMemberNamingConvention = new PascalCaseNamingConvention();
			
			// Graph Album Mappings
			graphSchemaToModel.CreateMap<Facebook.Schema.Graph.Album, Facebook.Models.Graph.Album>();
			graphModelToSchema.CreateMap<Facebook.Models.Graph.Album, Facebook.Schema.Graph.Album>();

			// Graph Application Mappings
			graphSchemaToModel.CreateMap<Facebook.Schema.Graph.Application, Facebook.Models.Graph.Application>();
			graphModelToSchema.CreateMap<Facebook.Models.Graph.Application, Facebook.Schema.Graph.Application>();

			// Graph Event Mappings
			graphSchemaToModel.CreateMap<Facebook.Schema.Graph.Event, Facebook.Models.Graph.Event>();
			graphModelToSchema.CreateMap<Facebook.Models.Graph.Event, Facebook.Schema.Graph.Event>();

			// Graph Group Mappings
			graphSchemaToModel.CreateMap<Facebook.Schema.Graph.Group, Facebook.Models.Graph.Group>();
			graphModelToSchema.CreateMap<Facebook.Models.Graph.Group, Facebook.Schema.Graph.Group>();

			// Graph Link Mappings
			graphSchemaToModel.CreateMap<Facebook.Schema.Graph.Link, Facebook.Models.Graph.Link>();
			graphModelToSchema.CreateMap<Facebook.Models.Graph.Link, Facebook.Schema.Graph.Link>();

			// Graph Note Mappings
			graphSchemaToModel.CreateMap<Facebook.Schema.Graph.Note, Facebook.Models.Graph.Note>();
			graphModelToSchema.CreateMap<Facebook.Models.Graph.Note, Facebook.Schema.Graph.Note>();

			// Graph Page Mappings
			graphSchemaToModel.CreateMap<Facebook.Schema.Graph.Page, Facebook.Models.Graph.Page>();
			graphModelToSchema.CreateMap<Facebook.Models.Graph.Page, Facebook.Schema.Graph.Page>();

			// Graph Photo Mappings
			graphSchemaToModel.CreateMap<Facebook.Schema.Graph.Photo, Facebook.Models.Graph.Photo>();
			graphModelToSchema.CreateMap<Facebook.Models.Graph.Photo, Facebook.Schema.Graph.Photo>();

			// Graph Post Mappings
			graphSchemaToModel.CreateMap<Facebook.Schema.Graph.Post, Facebook.Models.Graph.Post>();
			graphModelToSchema.CreateMap<Facebook.Models.Graph.Post, Facebook.Schema.Graph.Post>();

			// Graph Status Mappings
			graphSchemaToModel.CreateMap<Facebook.Schema.Graph.Status, Facebook.Models.Graph.Status>();
			graphModelToSchema.CreateMap<Facebook.Models.Graph.Status, Facebook.Schema.Graph.Status>();

			// Graph Subscription Mappings
			graphSchemaToModel.CreateMap<Facebook.Schema.Graph.Subscription, Facebook.Models.Graph.Subscription>();
			graphModelToSchema.CreateMap<Facebook.Models.Graph.Subscription, Facebook.Schema.Graph.Subscription>();

			// Graph User Mappings
			graphSchemaToModel.CreateMap<Facebook.Schema.Graph.User, Facebook.Models.Graph.User>();
			graphModelToSchema.CreateMap<Facebook.Models.Graph.User, Facebook.Schema.Graph.User>();

			// Graph Video Mappings
			graphSchemaToModel.CreateMap<Facebook.Schema.Graph.Video, Facebook.Models.Graph.Video>();
			graphModelToSchema.CreateMap<Facebook.Models.Graph.Video, Facebook.Schema.Graph.Video>();

					}
	
	}
}