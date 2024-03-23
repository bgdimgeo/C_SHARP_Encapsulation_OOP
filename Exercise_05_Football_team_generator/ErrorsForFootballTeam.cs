using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_05_Football_team_generator
{
    public static class ErrorsForFootballTeam
    {
        public static string NameIsEmptyOrNull = "A name should not be empty.";
        public static string StatError = "{0} should be between 0 and 100.";
        public static string PlayerDoesntExist = "Player {0} is not in {1} team.";
        public static string TeamDoesntExist = "Team {0} does not exist.";

    }
}
