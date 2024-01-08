import React from "react";


const Carrossel = () => {
  return (
    <div
      id="carouselExampleCaptions"
      className="carousel slide"
      data-bs-ride="carousel"
    >
      <div className="carousel-inner">
        <div className="carousel-item active">
          <img
            className="w-100 img-fluid d-none d-xl-block"
            src="/1.png"
            alt="Jornada"
          />

        </div>

      </div>

    </div>
  );
};

export default Carrossel;
