package com.blackbinn.gerenciador.servlet;

import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;

@WebServlet(name = "NovaEmpresaServlet", value = "/novaEmpresa")
public class NovaEmpresaServlet extends HttpServlet {

    @Override
    protected void service(HttpServletRequest request, HttpServletResponse response) throws IOException {

        // Método GET
        String nomeEmpresa = request.getParameter("nome");

        PrintWriter writer = response.getWriter();

        writer.println("<html>");
        writer.println("<body>");

        writer.println("<h1>");
        if (nomeEmpresa == null) {
            writer.println("Nenhuma empresa foi cadastrada no momento!");
        } else {
            writer.println("Empresa " + nomeEmpresa + " cadastrada com sucesso!");
        }
        writer.println("</h1>");

        writer.println("</body>");
        writer.println("</html>");
    }
}
