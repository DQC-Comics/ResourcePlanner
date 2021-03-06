﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using OrderData.Models;

namespace OrderData.Models
{
    public partial class DbHeroSkill
    {
        private DbHero _hero;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public DbHero Hero
        {
            get { return this._hero; }
            set { this._hero = value; }
        }
        
        private int? _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private double? _level;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public double? Level
        {
            get { return this._level; }
            set { this._level = value; }
        }
        
        private double? _rating;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public double? Rating
        {
            get { return this._rating; }
            set { this._rating = value; }
        }
        
        private double? _ratingCount;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public double? RatingCount
        {
            get { return this._ratingCount; }
            set { this._ratingCount = value; }
        }
        
        private DbSkill _skill;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public DbSkill Skill
        {
            get { return this._skill; }
            set { this._skill = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DbHeroSkill class.
        /// </summary>
        public DbHeroSkill()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken heroValue = inputObject["Hero"];
                if (heroValue != null && heroValue.Type != JTokenType.Null)
                {
                    DbHero dbHero = new DbHero();
                    dbHero.DeserializeJson(heroValue);
                    this.Hero = dbHero;
                }
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((int)idValue);
                }
                JToken levelValue = inputObject["Level"];
                if (levelValue != null && levelValue.Type != JTokenType.Null)
                {
                    this.Level = ((double)levelValue);
                }
                JToken ratingValue = inputObject["Rating"];
                if (ratingValue != null && ratingValue.Type != JTokenType.Null)
                {
                    this.Rating = ((double)ratingValue);
                }
                JToken ratingCountValue = inputObject["RatingCount"];
                if (ratingCountValue != null && ratingCountValue.Type != JTokenType.Null)
                {
                    this.RatingCount = ((double)ratingCountValue);
                }
                JToken skillValue = inputObject["Skill"];
                if (skillValue != null && skillValue.Type != JTokenType.Null)
                {
                    DbSkill dbSkill = new DbSkill();
                    dbSkill.DeserializeJson(skillValue);
                    this.Skill = dbSkill;
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type DbHeroSkill
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Hero != null)
            {
                outputObject["Hero"] = this.Hero.SerializeJson(null);
            }
            if (this.Id != null)
            {
                outputObject["Id"] = this.Id.Value;
            }
            if (this.Level != null)
            {
                outputObject["Level"] = this.Level.Value;
            }
            if (this.Rating != null)
            {
                outputObject["Rating"] = this.Rating.Value;
            }
            if (this.RatingCount != null)
            {
                outputObject["RatingCount"] = this.RatingCount.Value;
            }
            if (this.Skill != null)
            {
                outputObject["Skill"] = this.Skill.SerializeJson(null);
            }
            return outputObject;
        }
    }
}
