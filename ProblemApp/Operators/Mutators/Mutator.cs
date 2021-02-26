using ProblemApp.Algorithms;
using ProblemApp.Problems;
using ProblemApp.Solutions;

namespace ProblemApp.Operators.Mutators
{
    public abstract class Mutator : IOperator
    {
        public abstract TOperator Copy<TOperator>() where TOperator : Mutator;

        public abstract void SetAlgorithm<TAlgorithm>(TAlgorithm algorithm) where TAlgorithm : IAlgorithm<IProblem>;

        public abstract void MutateCoordinates<TSolution>(TSolution[] solutions) where TSolution : IPoint;
    }
}