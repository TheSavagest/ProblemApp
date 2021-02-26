using ProblemApp.Algorithms;
using ProblemApp.Problems.Functions;

namespace ProblemApp.Operators.Mutators
{
    public class Uniform : Mutator
    {
        public override TOperator Copy<TOperator>() where TOperator : Mutator
        {
            return new Uniform();
        }

        public override void SetAlgorithm<TAlgorithm>(TAlgorithm algorithm) where TAlgorithm : IAlgorithm<Function>
        {
            throw new System.NotImplementedException();
        }

        public override void MutateCoordinates<TSolution>(TSolution[] solutions)
        {
            throw new System.NotImplementedException();
        }
    }
}