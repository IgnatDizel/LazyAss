using System;
using System.Collections.Generic;

namespace LazyAss.DAL.Core.Domain
{
    public class LazyUser
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Name { get; set; }
        public int? PhoneNumber { get; set; }

        public virtual IList<LazyUserTvSeries> LazyUserTvSeries { get; set; }
    }
}
