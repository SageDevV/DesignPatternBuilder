namespace DesignPatternBuilder
{
    public class GenericActionBuilder : 
        IWorkFlow,
        IWorkFlowName,
        IWorkFlowOld,
        IWorkFinalStep
    {
        private GenericActionBuilder()
        {

        }

        public static IWorkFlow Configure()
            => new GenericActionBuilder();

        public IWorkFlowName WithName(string name)
            => this;

        public IWorkFlowOld WithOld(int idade)
            => this;

        public IWorkFinalStep WithStep()
            => this;
    }

    //Interfaces com seus contratos específicos

    public interface IWorkFlow {
        public IWorkFlowName WithName(string name);
    }

    public interface IWorkFlowName
    {
        public IWorkFlowOld WithOld(int idade);
    }

    public interface IWorkFlowOld
    {
        public IWorkFinalStep WithStep();
    }

    public interface IWorkFinalStep
    {
    }
}
