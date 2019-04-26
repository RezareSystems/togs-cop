using System.Threading.Tasks;

namespace Rezare.TogsCop.Integration.WorkFlowMax.Api
{
    public interface IWorkFlowMaxApiFactory
    {
        Task<T> Create<T>() where T : IWorkFlowMaxApi;
    }
}
