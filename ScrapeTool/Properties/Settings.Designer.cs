﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScrapeTool.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("www.tripadvisor.jp")]
        public string HOSTS_TRIP {
            get {
                return ((string)(this["HOSTS_TRIP"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("www.yelp")]
        public string HOSTS_YELP {
            get {
                return ((string)(this["HOSTS_YELP"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("120")]
        public int trip_limit {
            get {
                return ((int)(this["trip_limit"]));
            }
            set {
                this["trip_limit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.businessName__373c0__1fTgn a")]
        public string yelp_selector_title {
            get {
                return ((string)(this["yelp_selector_title"]));
            }
            set {
                this["yelp_selector_title"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.businessName__373c0__1fTgn a")]
        public string yelp_selector_url {
            get {
                return ((string)(this["yelp_selector_url"]));
            }
            set {
                this["yelp_selector_url"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.businessName__373c0__1fTgn h3")]
        public string yelp_selector_rank {
            get {
                return ((string)(this["yelp_selector_rank"]));
            }
            set {
                this["yelp_selector_rank"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int yelp_limit {
            get {
                return ((int)(this["yelp_limit"]));
            }
            set {
                this["yelp_limit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.title a")]
        public string trip_restaurant_selector_title {
            get {
                return ((string)(this["trip_restaurant_selector_title"]));
            }
            set {
                this["trip_restaurant_selector_title"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.title a")]
        public string trip_restaurant_selector_url {
            get {
                return ((string)(this["trip_restaurant_selector_url"]));
            }
            set {
                this["trip_restaurant_selector_url"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".popIndexBlock .popIndexDefault")]
        public string trip_restaurant_selector_rank {
            get {
                return ((string)(this["trip_restaurant_selector_rank"]));
            }
            set {
                this["trip_restaurant_selector_rank"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.listing_title a")]
        public string trip_activities_selector_title {
            get {
                return ((string)(this["trip_activities_selector_title"]));
            }
            set {
                this["trip_activities_selector_title"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.listing_title a")]
        public string trip_activities_selector_url {
            get {
                return ((string)(this["trip_activities_selector_url"]));
            }
            set {
                this["trip_activities_selector_url"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".popRanking")]
        public string trip_activities_selector_rank {
            get {
                return ((string)(this["trip_activities_selector_rank"]));
            }
            set {
                this["trip_activities_selector_rank"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".pagination span.next.disabled")]
        public string trip_next_element {
            get {
                return ((string)(this["trip_next_element"]));
            }
            set {
                this["trip_next_element"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.mainAttributes__373c0__1r0QA")]
        public string yelp_selector_item {
            get {
                return ((string)(this["yelp_selector_item"]));
            }
            set {
                this["yelp_selector_item"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.listing:not(.listingIndex-n)")]
        public string trip_selector_item {
            get {
                return ((string)(this["trip_selector_item"]));
            }
            set {
                this["trip_selector_item"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("300")]
        public int jalan_limit {
            get {
                return ((int)(this["jalan_limit"]));
            }
            set {
                this["jalan_limit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("p.item-name a")]
        public string jalan_selector_title {
            get {
                return ((string)(this["jalan_selector_title"]));
            }
            set {
                this["jalan_selector_title"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("p.item-name a")]
        public string jalan_selector_url {
            get {
                return ((string)(this["jalan_selector_url"]));
            }
            set {
                this["jalan_selector_url"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("p.item-name span")]
        public string jalan_selector_rank {
            get {
                return ((string)(this["jalan_selector_rank"]));
            }
            set {
                this["jalan_selector_rank"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("www.jalan.net")]
        public string HOSTS_JALAN {
            get {
                return ((string)(this["HOSTS_JALAN"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.item-listContents")]
        public string jalan_selector_item {
            get {
                return ((string)(this["jalan_selector_item"]));
            }
            set {
                this["jalan_selector_item"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4travel.jp")]
        public string HOSTS_4TRA {
            get {
                return ((string)(this["HOSTS_4TRA"]));
            }
            set {
                this["HOSTS_4TRA"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.u_areaListRankingBox")]
        public string fortra_selector_item {
            get {
                return ((string)(this["fortra_selector_item"]));
            }
            set {
                this["fortra_selector_item"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".u_title h2")]
        public string fortra_selector_title {
            get {
                return ((string)(this["fortra_selector_title"]));
            }
            set {
                this["fortra_selector_title"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".u_title h2 a")]
        public string fortra_selector_url {
            get {
                return ((string)(this["fortra_selector_url"]));
            }
            set {
                this["fortra_selector_url"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".u_title .u_iconRanking")]
        public string fortra_selector_rank {
            get {
                return ((string)(this["fortra_selector_rank"]));
            }
            set {
                this["fortra_selector_rank"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".u_rankBox .evaluateNumber")]
        public string fortra_selector_review {
            get {
                return ((string)(this["fortra_selector_review"]));
            }
            set {
                this["fortra_selector_review"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int fortra_limit {
            get {
                return ((int)(this["fortra_limit"]));
            }
            set {
                this["fortra_limit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.rating .ui_bubble_rating")]
        public string trip_rating {
            get {
                return ((string)(this["trip_rating"]));
            }
            set {
                this["trip_rating"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.rating span.more a,div.rating span.reviewCount a")]
        public string trip_review_count {
            get {
                return ((string)(this["trip_review_count"]));
            }
            set {
                this["trip_review_count"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.i-stars__373c0__Y2F3O")]
        public string yelp_rating {
            get {
                return ((string)(this["yelp_rating"]));
            }
            set {
                this["yelp_rating"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("div.venueDetails")]
        public string forsq_selector_item {
            get {
                return ((string)(this["forsq_selector_item"]));
            }
            set {
                this["forsq_selector_item"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".venueName h2 a")]
        public string forsq_selector_title {
            get {
                return ((string)(this["forsq_selector_title"]));
            }
            set {
                this["forsq_selector_title"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".venueName h2 a")]
        public string forsq_selector_url {
            get {
                return ((string)(this["forsq_selector_url"]));
            }
            set {
                this["forsq_selector_url"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".u_title .u_iconRanking")]
        public string forsq_selector_rank {
            get {
                return ((string)(this["forsq_selector_rank"]));
            }
            set {
                this["forsq_selector_rank"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".venueScore")]
        public string forsq_selector_rating {
            get {
                return ((string)(this["forsq_selector_rating"]));
            }
            set {
                this["forsq_selector_rating"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int base_limit {
            get {
                return ((int)(this["base_limit"]));
            }
            set {
                this["base_limit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ja.foursquare.com")]
        public string HOSTS_4SQ {
            get {
                return ((string)(this["HOSTS_4SQ"]));
            }
            set {
                this["HOSTS_4SQ"] = value;
            }
        }
    }
}
