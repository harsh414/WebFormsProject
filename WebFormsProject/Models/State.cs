using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsProject.Models
{
    public class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
    }

    public class States: List<State>
    {
        public States()
        {
            Add(new State() { StateId = 1, StateName = "Maharashtra" });
            Add(new State() { StateId = 2, StateName = "Delhi" });
        }
    }
}