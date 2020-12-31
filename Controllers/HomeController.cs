using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Pagina_Captura.Models;


namespace Pagina_Captura.Controllers
{
    public class HomeController : Controller
    {

        private readonly IConfiguration _config;


        public HomeController(IConfiguration config)
        {
            _config= config;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Cadastro preCadastro)
        {
            
            var emailExistente = FindByEmail(preCadastro.Email);

            if (emailExistente)
            {
                ViewData["erro"] = "E-mail já cadastrado!";

                if (ViewData["erro"] != null)
                {
                    ModelState.AddModelError(string.Empty, ViewData["erro"].ToString());
                }
                return View("index");
            }
            else
            {
                var sql = $"insert into heroku_dc5e1761d601134.preinscricao (nome, celular, email) values('{preCadastro.Nome}', '{preCadastro.Celular}', '{preCadastro.Email}')";
                using (MySqlConnection conexao = new MySqlConnection(
                 _config.GetConnectionString("myConnection")))
                {
                    conexao.Execute(sql);
                }
                try
                {
                    EnviaEmail(preCadastro.Email);

                }
                catch
                {

                }
                return RedirectToAction("Success");
            }


        }
        public IActionResult Admin()
        {

            return View();
        }

        public IActionResult Success()
        {

            return View();
        }

        public IActionResult ErroCadastro()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void EnviaEmail(string emailAluna)
        {
            string emailServico = "studiopinxesacurso@gmail.com";
            string emailDepartamento = emailAluna;
            string tituloEmail = "Pré-Inscrição Princess Lips ";
            string mensagem = "<p>Olá, </p><p></p>" +
                              "<p>Sua pré-Inscrição no Curso Princess Lips foi efetuada com sucesso. </p>" +
                              "<p> Aguarde mais informações</p>" +
                              "<br/><strong>Acesse o </strong> <a href='http://princesslips.com.br '>Site Princess Lips </a>." +
                              "<p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p><p><small>Esta é uma mensagem automática por favor, não responda.</small></p>"

                ;
            string servidor = "smtp.gmail.com";
            int porta = 587;
            string senha = "Studio01@1";

          
                try
                {
                    MailMessage _mailMessage = new MailMessage();
                    _mailMessage.From = new MailAddress(emailServico);
                    _mailMessage.CC.Add(emailDepartamento);
                    _mailMessage.Subject = tituloEmail;
                    _mailMessage.IsBodyHtml = true;
                    _mailMessage.Body = mensagem;
                    SmtpClient _smtpClient = new SmtpClient(servidor, porta);
                    _smtpClient.UseDefaultCredentials = false;
                    _smtpClient.Credentials = new NetworkCredential(emailServico, senha);
                    _smtpClient.EnableSsl = true;
                    _smtpClient.Send(_mailMessage);
                    //string aviso = "E-mail enviado";
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            
        }
        public bool FindByEmail(string email)
        {
            Aluno result;
            var sql = $"select email from heroku_dc5e1761d601134.preinscricao where email = '{email}'";
            using (MySqlConnection conexao = new MySqlConnection(
             _config.GetConnectionString("myConnection")))
            {
                result = conexao.QueryFirstOrDefault<Aluno>(sql);
            }

            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
