using ProblemApp.Algorithms;
using ProblemApp.Problems;

namespace ProblemApp.Operators
{
    public interface IOperator
    {
        public TOperator Copy<TOperator>() where TOperator : IOperator;

        public void SetAlgorithm(IAlgorithm<IProblem> algorithm);
    }
}