using BB_BusinessDataLogic;
using BB_Common;
using Microsoft.AspNetCore.Mvc;

namespace BBWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BudgetBController : Controller
    {
        private readonly BB_BusinessDataLogic.BBProcess _bbProcess;

        public BudgetBController(BB_BusinessDataLogic.BBProcess bbProcess)
        {
            _bbProcess = bbProcess;
        }

        [HttpGet]
        public IEnumerable<UserAccounts> GetAccounts()
        {
            List<UserAccounts> userAccounts = BBProcess.GetAccounts();
            return userAccounts;
        }

        [HttpPatch("Increase")]
        public bool  Increase(double Amount, string userUsername, string userPassword)
        {
            var actions = BB_BusinessDataLogic.Actions.Increase;
            var result = BBProcess.UpdateWeeklyAllowance(Amount, actions,userUsername, userPassword);
            return result;
        }

        [HttpPatch("Decrease")]
        public bool Decrease(double Amount, string userUsername, string userPassword)
        {
            var actions = BB_BusinessDataLogic.Actions.Decrease;
            var result = BBProcess.UpdateWeeklyAllowance(Amount, actions, userUsername, userPassword);
            return result;
        }

        [HttpDelete]
        public bool DeleteAccount(string userUsername, string userPassword)
        {
           var result= _bbProcess.DeleteAccount(userUsername, userPassword);
            return result;
        }

        [HttpPost]
        public bool CreateAccount(string userUsername, string userPassword, double allowance)
        {
           var result= _bbProcess.CreateAccount( userUsername,  userPassword, allowance);
            return result;
        }
    }
}
