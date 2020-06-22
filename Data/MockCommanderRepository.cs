using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
        new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Platform = "Kettle & Pan" },
        new Command { Id = 1, HowTo = "Cut Bread", Line = "Get a knife", Platform = "Knife and chopping board" },
        new Command { Id = 2, HowTo = "Make a cup of tea", Line = "Place a teabag in cup", Platform = "Kettle & Cup" }
      };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil and Egg", Line = "Boil Water", Platform = "Kettle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}