import React from "react";
import "./Busca.css";

const Busca = () => {
  return (
    <div className="container row mx-auto justify-content-center barra-busca my-3">
      <div className="row p-1">
        <form>
          <div className="row">
            <div className="form-group col-md-3 ">
              <label>Passagens:</label>
              <input
                type="text"
                className="form-control"
                placeholder="Origem"
              />
            </div>
            <div className="form-group col-md-3">
              <label>&nbsp;</label>
              <input
                type="text"
                className="form-control"
                placeholder="Destino"
              />
            </div>
            <div className="form-group col-md-2">
              <label>
                <i className=" fa fa-fw fa-calendar-times" /> Ida:
              </label>
              <input
                type="date"
                className="form-control"
                placeholder="Destino"
              />
            </div>
            <div className="form-group col-md-2">
              <label>
                <i className=" fa fa-fw fa-calendar-times" /> Volta:
              </label>
              <input
                type="date"
                className="form-control"
                placeholder="Destino"
              />
            </div>
            <div className="form-group col-md-2">
              <label htmlFor="inputState">
                <i className="fa fa-user" /> Passageiros:
              </label>
              <select className="form-control">
                <option>1 Adulto</option>
                <option>2 Adultos</option>
                <option>1 Adulto + 1 Criança</option>
                <option>2 Adultos + 1 Criança</option>
              </select>
            </div>
            <div className="form-group mt-2">
              <label>
                <i className="bi bi-airplane" />
              </label>
              <button type="submit" className="btn btn-dark botao-laranja">
                Buscar
              </button>
            </div>
          </div>
        </form>
      </div>
    </div>
  );
};

export default Busca;
