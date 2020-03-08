﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Plugins.GAP.Editor.Users
{
    public class Collaborator
    {
        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }

        public struct permissions
        {
            public bool admin { get; set; }
            public bool push { get; set; }
            public bool pull { get; set; }
        }
    }
}
