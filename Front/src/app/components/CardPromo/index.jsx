import React from "react";

const CardPromo = ({imagem, descricao, cidade, valor}) => {
  return (
    <div className="col-12 col-sm-12 col-md-6 col-xl-6 col-xxl-4 pb-4 tamanho">
      <div className="card">
        <img
          src={imagem}
          alt={descricao}
        />
        <div className="card-body">
          <h5 className="card-title fw-bold">{cidade}</h5>
          <p className="card-text">
            {descricao}
          </p>
          <p className="fw-bold">{valor}</p>
          <a href="#" className="btn btn-dark botao-laranja rounded-0 border-0">
            Ver mais
          </a>
        </div>
      </div>
    </div>
  );
};

export default CardPromo;
