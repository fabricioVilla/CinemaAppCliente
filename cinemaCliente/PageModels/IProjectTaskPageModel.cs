using CommunityToolkit.Mvvm.Input;
using cinemaCliente.Models;

namespace cinemaCliente.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}