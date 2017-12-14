/*
 * GitPushr.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using GitPushr.Standard;
using GitPushr.Standard.Utilities;


namespace GitPushr.Standard.Models
{
    public class Repo : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private bool mprivate;
        private string owner;
        private string url;
        private string fullName;
        private object raw;
        private string organisation;

        /// <summary>
        /// The name of the repoistory
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// True if the repo is private
        /// </summary>
        [JsonProperty("private")]
        public bool Private 
        { 
            get 
            {
                return this.mprivate; 
            } 
            set 
            {
                this.mprivate = value;
                onPropertyChanged("Private");
            }
        }

        /// <summary>
        /// The owner of the API, if part of a team, then the owner is the same as organisation
        /// </summary>
        [JsonProperty("owner")]
        public string Owner 
        { 
            get 
            {
                return this.owner; 
            } 
            set 
            {
                this.owner = value;
                onPropertyChanged("Owner");
            }
        }

        /// <summary>
        /// The url of the repository
        /// </summary>
        [JsonProperty("url")]
        public string Url 
        { 
            get 
            {
                return this.url; 
            } 
            set 
            {
                this.url = value;
                onPropertyChanged("Url");
            }
        }

        /// <summary>
        /// The URL/Homepage of the repository
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName 
        { 
            get 
            {
                return this.fullName; 
            } 
            set 
            {
                this.fullName = value;
                onPropertyChanged("FullName");
            }
        }

        /// <summary>
        /// The raw repository object provided by the git vendor
        /// </summary>
        [JsonProperty("raw")]
        public object Raw 
        { 
            get 
            {
                return this.raw; 
            } 
            set 
            {
                this.raw = value;
                onPropertyChanged("Raw");
            }
        }

        /// <summary>
        /// The name of the orgnisation if its part of a team
        /// </summary>
        [JsonProperty("organisation")]
        public string Organisation 
        { 
            get 
            {
                return this.organisation; 
            } 
            set 
            {
                this.organisation = value;
                onPropertyChanged("Organisation");
            }
        }
    }
} 