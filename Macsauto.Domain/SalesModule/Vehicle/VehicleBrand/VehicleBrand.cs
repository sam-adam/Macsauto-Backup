﻿namespace Macsauto.Domain.SalesModule
{
    using Macsauto.Domain.Shared;

    /// <summary>
    /// Represents an actual vehicle brand / dealer
    /// Examples : Toyota, Honda, Daihatsu
    /// </summary>
    public class VehicleBrand : Entity
    {
        private string _name;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        public VehicleBrand(string code, string name) : base(code)
        {
            _name = name;
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}