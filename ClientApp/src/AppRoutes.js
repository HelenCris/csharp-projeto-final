import { Home } from "./components/Home";
import { Login } from "./components/Login";
import { Cadastro } from "./components/Cadastro";
import { Consultas } from "./components/Consultas";
import { Ajuda } from "./components/Ajuda";
import { SaidaSistema } from "./components/SaidaSistema";

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
  },
  {
    path: '/saidaSistema',
    element: <SaidaSistema />
  }
  
];

export default AppRoutes;
