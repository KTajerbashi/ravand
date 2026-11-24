using Ravand.Core.Application.UseCases.Aggregate;

namespace Ravand.EndPoint.WebApi.Controllers.Test
{
    public class TestController : AuthController
    {
        [HttpPost]
        public async Task<IActionResult> Add(AddAggregateCommand command)
        {
            await Task.CompletedTask;

            //Database.Products.Add(new(Guid.NewGuid(), parameters.Title, parameters.Price, parameters.Rate));
            return Ok(command);
        }
    }
}
