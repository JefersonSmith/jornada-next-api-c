import Link from "next/link";

export default function Header() {
  return (
    <header className="header">
      <img src="/logo rosa.png" alt="logo" />
      <ul>
        <li>
          <div className="botao">
            <Link href="/">Home</Link>
          </div>
        </li>
        <li>
          <div className="botao">
            <Link href="/Destinos">Destinos</Link>
          </div>
        </li>
        <li>
          <div className="botao">
            <Link href="/Contato">Contato</Link>
          </div>
        </li>
      </ul>
    </header>
  );
}
