using ProblemApp.Algorithms;
using ProblemApp.Problems.Functions;

namespace ProblemApp.Operators.Mutators
{
    public class NonUniform : Mutator
    {
        public override TOperator Copy<TOperator>()
        {
            throw new System.NotImplementedException();
        }

        public override void SetAlgorithm<TAlgorithm>(TAlgorithm algorithm) where TAlgorithm : IIterativeAlgorithm<Function>
        {
            throw new System.NotImplementedException();
        }

        public override void MutateCoordinates<TSolution>(TSolution[] solutions)
        {
            throw new System.NotImplementedException();
        }
    }
}