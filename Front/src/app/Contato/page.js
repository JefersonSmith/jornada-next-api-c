import React from "react";
import Carrossel from "../components/Carrossel";
import 'bootstrap/dist/css/bootstrap.min.css';
import '../globals.css'


const Contato = () => {
  return (
    <div>
      <Carrossel />
      <div class="container row mx-auto justify-content-center">
        <form className="form-contato">
          <div className="form-group label-form">
            <label htmlFor="exampleFormControlInput1">Endereço de email</label>
            <input
              type="email"
              className="form-control"
              id="exampleFormControlInput1"
              placeholder="nome@email.com"
            />
            <label htmlFor="exampleFormControlInput1">Telefone</label>
            <input
              type="tel"
              className="form-control"
              id="exampleFormControlInput1"
              placeholder="(xx)xxxxx-xxxx"
            />
          </div>
          <div className="form-group label-form">
            <label htmlFor="exampleFormControlSelect1">Assunto</label>
            <select className="form-control" id="exampleFormControlSelect1">
              <option>Viagens</option>
              <option>Informações de Pagamento</option>
              <option>Dúvidas</option>
              <option>Reclamações</option>
              <option>Cancelamentos</option>
            </select>
          </div>
          <div className="form-group label-form">
            <label htmlFor="exampleFormControlTextarea1">
              Escreva sua mensagem abaixo
            </label>
            <textarea
              className="form-control"
              id="exampleFormControlTextarea1"
              rows={3}
              defaultValue={""}
            />
            <button
              type="submit"
              className="btn btn-dark botao-laranja rounded-0 border-0"
            >
              Enviar
            </button>
          </div>
        </form>
        <div className="mapa-responsivo">
          <iframe
            src="https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d3685.8363425146017!2d-43.18052102387794!3d-22.51032267953608!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1spt-BR!2sbr!4v1690728104397!5m2!1spt-BR!2sbr"
            width={400}
            height={300}
            style={{ border: 0 }}
            allowFullScreen=""
            loading="lazy"
            referrerPolicy="no-referrer-when-downgrade"
          />
        </div>
      </div>
    </div>
  );
};

export default Contato;
