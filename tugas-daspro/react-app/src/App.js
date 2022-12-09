import "./assets/scss/App.css"
import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom"

import logo from "./assets/logounri.png"

import Account from "./components/Account"
import Blog from "./components/Blog"
import User from "./components/User"

function App() {
  return (
    <div className="App">
    <Router>
      <nav>
        <Link className="link" to="/"> Home </Link> |
        <Link className="link" to="/account"> Account </Link> |
        <Link className="link" to="/blog"> Blog </Link>
      </nav>
      <img src={logo} className="App-logo" />
      <Routes>
        <Route exact path="/" element={<User />} />
        <Route path="/account" element={<Account />} />
        <Route path="/blog" element={<Blog />} />
      </Routes>
    </Router>
    </div>
  );
}

export default App