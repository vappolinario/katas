using System.Collections.Generic;
using System.Linq;

namespace Assembler
{
    public readonly struct Command
    {
        public Command(string[] tokens)
        {
            Keyword = tokens[0];
            Register = tokens[1];
            Value = tokens.Length == 3 ? tokens[2] : "";
        }

        public string Keyword { get; }
        public string Register { get; }
        public string Value { get; }
    }

    public class SimpleAssembler
    {
        public static Dictionary<string, int> Interpret(string[] program)
        {
            var registers = new Dictionary<string, int>();
            var instructions = program.Select(s => new Command(s.Split(' '))).ToArray();
            for (int position = 0; position < instructions.Count();)
            {
                position = Run(instructions[position], registers, position);
            }
            return registers;
        }

        private static int Run(Command command, Dictionary<string, int> registers, int position)
        {
            var jump = 1;
            switch (command.Keyword)
            {
                case "mov":
                    Mov(command, registers);
                    break;
                case "inc":
                    Inc(command, registers);
                    break;
                case "dec":
                    Dec(command, registers);
                    break;
                case "jnz":
                    jump = Jnz(command, registers);
                    break;
                default:
                    break;
            }
            return position + jump;
        }

        private static int GetCommandValue(Command command, Dictionary<string, int> registers)
        {
            if (int.TryParse(command.Value, out int result))
            {
                return result;
            }
            return registers[command.Value];
        }

        private static void Mov(Command command, Dictionary<string, int> registers)
        {
            registers[command.Register] = GetCommandValue(command, registers);
        }

        private static void Dec(Command command, Dictionary<string, int> registers)
        {
            if (registers.TryGetValue(command.Register, out int value))
            {
                registers[command.Register] = --value;
            }
        }

        private static void Inc(Command command, Dictionary<string, int> registers)
        {
            if (registers.TryGetValue(command.Register, out int value))
            {
                registers[command.Register] = ++value;
            }
        }

        private static int Jnz(Command command, Dictionary<string, int> registers)
        {
            if (registers.TryGetValue(command.Register, out int value))
            {
                return value != 0 ? GetCommandValue(command, registers) : 1;
            }
            return GetCommandValue(command, registers);
        }

    }
}
