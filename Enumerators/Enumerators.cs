namespace Cookbook.Common.Contracts.Enumerators;

public class Enumerators
{
    public enum MassTypes
    {
        None = 0,
        Piece = 1,
        Box = 2,
        kg = 3,
        hg = 4,
        g = 5,
        l = 6,
        dl = 7,
        cl = 8,
        ml = 9
    }

    public enum DifficultyLevel
    {
        Easy = 1,
        Medium = 2,
        Hard = 3
    }
        
    public enum LogicalOperator
    {
        And,
        Or,
    }
}