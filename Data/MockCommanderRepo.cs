using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
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
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo="Placeholder1", Line = "Placeholder1", Platform = "Placeholder1"},
                new Command{Id = 0, HowTo="Placeholder2", Line = "Placeholder2", Platform = "Placeholder2"},
                new Command{Id = 0, HowTo="Placeholder3", Line = "Placeholder3", Platform = "Placeholder3"},
            };

            return commands;
        }

        public Command GetCommandByID(int id)
        {
            return new Command { Id = id, HowTo = "Placeholder", Line = "Placeholder", Platform = "Placeholder" };
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