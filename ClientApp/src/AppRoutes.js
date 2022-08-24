import { Home } from "./components/Home/index";
import { Login } from "./components/Login/index";
import { Cadastro } from "./components/Cadastro/index";
import { Consultas } from "./components/Consultas/index";
import { Ajuda } from "./components/Ajuda/index";

// rotas das paginas 
const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/login',
    element: <Login />
  },
  {
    path: '/cadastro',
    element: <Cadastro />
  },
  {
    path: '/consultas',
    element: <Consultas />
  },
  {
    path: '/ajuda',
    element: <Ajuda />
  }
  
];

export default AppRoutes;
