using NUnit.Framework;
using TechTalk.SpecFlow;


namespace SpecFlowDemo.Steps
{
    [Binding]

    public sealed class Definicao
    {
        private readonly ScenarioContext _scenarioContext;
        private string Nome  {get; set;}
        private string Email  {get; set;}
        private string Senha  {get; set;}


        public Definicao(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When("i add (.*) and (.*) and (.*)")]
        public void QuandoAdicionoNome(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        [Then("the result should be (.*)")]
        public void ResultadoNome(string result)
        {
            Assert.AreEqual((Nome + Email + Senha),  result);
        }


               
    }
}