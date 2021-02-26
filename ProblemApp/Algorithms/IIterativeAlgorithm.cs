using ProblemApp.Problems;

namespace ProblemApp.Algorithms
{
    public interface IIterativeAlgorithm<TProblem> : IAlgorithm<TProblem> where TProblem : IProblem
    {
        int CurrentIteration { get; }
    }
}