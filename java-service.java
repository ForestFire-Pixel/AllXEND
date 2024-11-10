// java-service.java
import java.io.*;
import javax.servlet.*;
import javax.servlet.http.*;

public class JavaService extends HttpServlet {
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        response.setContentType("text/plain");
        response.getWriter().println("Java Service: User authenticated!");
    }
}
