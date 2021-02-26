using ProblemApp.Problems;

namespace ProblemApp.Algorithms
{
    public interface IAlgorithm<TProblem> where TProblem : IProblem
    {
        TProblem? Problem { get; set; }
    }
}