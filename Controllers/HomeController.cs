using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancias do Tipo Clientes
        Cliente cliente1 = new Cliente(01, "Maria Fereira da Silva", "123.654.594-34", "mariafsilva21@gmail.com", "Chaves");
        Cliente cliente2 = new Cliente(02, "Antonio Francisca Pereira", "987.654.321-01", "afpfrancisco@gmail.com", "Muralha");
        Cliente cliente3 = new Cliente(03, "Pedro Paulo de Lima", "789.456.123-05", "pplpaulo@gmail.com", "Xuxa");
        Cliente cliente4 = new Cliente(04, "Vinicius Magalhães de souza", "159.753.492-65", "vmsmagalhaes@gmail.com", "Rico");
        Cliente cliente5 = new Cliente(05, "Diego da Silva", "852.963.71-56", " diegosilva@gmail.com", "Guga");


        //lista de cientes e atribui os clientes
        List<Cliente> listaclientes = new List<Cliente>();
        listaclientes.Add(cliente1);
        listaclientes.Add(cliente2);
        listaclientes.Add(cliente3);
        listaclientes.Add(cliente4);
        listaclientes.Add(cliente5);

        ViewBag.listaclientes = listaclientes;

        // Instacias do Tipo Fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A","14.182.102/0001-00","C#sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog","15.836.698/0001-57","ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "gootPet IMC","49.819.224/0001-32","boots.pet@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Fik Tok Dogs","87.945.350/0001-09","fiktokdogs@hotmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Meus Pets Carinho","18.760.614/0001-37","mpcdogs@gov.br");

        // lista de fornecedores e atribui  os fornecedores
        List<Fornecedor> listafornecedor = new List<Fornecedor>();
        listafornecedor.Add(fornecedor1);
        listafornecedor.Add(fornecedor2);
        listafornecedor.Add(fornecedor3);
        listafornecedor.Add(fornecedor4);
        listafornecedor.Add(fornecedor5);

        ViewBag.listafornecedor = listafornecedor;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
