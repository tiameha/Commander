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
            var Commands = new List<Command>
            {
                new Command{ Id=0, HowTo="Boil egg", Line="Boil water", Platform="Kettle"},
                new Command{ Id=1, HowTo="Make Toast", Line="Toast Bread", Platform="Toaster"},
                new Command{ Id=2, HowTo="Make Coffee", Line="Brew java", Platform="Coffee pot"}
            };

            return Commands;

        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil egg", Line = "Boil water", Platform = "Kettle" };

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