import React from "react";
import 'bootstrap/dist/css/bootstrap.min.css';
// import { Airplane, BagCheck, ArrowCounterclockwise } from "react-bootstrap-icons";


const CardInformacoes = () => {
  return (
    <section className="pb-4 bg-black text-bg-dark">
      <h2 className="text-center py-3">Dúvidas Frequentes</h2>
      <div className="d-flex flex-column flex-lg-row align-items-center justify-content-center gap-3 px-3">
        <div className="facilidades d-flex">
          <div>
            <i className="verde-limao fs-1" />
          </div>
          <div>
            <div className="ms-3 mb-1 verde-limao">
              COMO FUNCIONA A JORNADA?
            </div>
            <div className="fonte-menor ms-3">
              Na Jornada, estamos comprometidos em tornar suas viagens
              memoráveis. Nossa agência oferece um serviço completo, que inclui
              a seleção cuidadosa dos melhores destinos, acomodações de
              qualidade e opções de transporte convenientes. Além disso, nossos
              especialistas em viagens estão sempre prontos para ajudar a
              planejar itinerários personalizados de acordo com suas
              preferências. Com a Jornada, você pode relaxar e desfrutar da
              experiência, enquanto cuidamos de todos os detalhes para você.
            </div>
          </div>
        </div>
        <div className="facilidades d-flex">
          <div>
            <i className="verde-limao fs-1" />
          </div>
          <div>
            <div className="ms-3 mb-1 verde-limao">
              É SEGURO COMPRAR NA JORNADA?
            </div>
            <div className="fonte-menor ms-3">
              Sim, sua segurança é uma prioridade para nós. Na Jornada, adotamos
              medidas rigorosas para proteger suas informações pessoais e
              financeiras. Utilizamos tecnologias de segurança avançadas para
              garantir que todas as transações sejam criptografadas e
              processadas com segurança. Além disso, trabalhamos apenas com
              parceiros confiáveis e estabelecidos no setor do turismo, para
              garantir que você receba serviços de alta qualidade e esteja
              protegido em todas as etapas da sua jornada.
            </div>
          </div>
        </div>
        <div className="facilidades d-flex">
          <div>
            <i className="bi fs-1" />
          </div>
          <div>
            <div className="ms-3 mb-1 verde-limao">
              É POSSÍVEL ALTERAR OU CANCELAR UMA COMPRA?
            </div>
            <div className="fonte-menor ms-3">
              Sim, entendemos que planos de viagem podem mudar. Na Jornada,
              oferecemos flexibilidade para alterações e cancelamentos, sempre
              que possível. No entanto, é importante ressaltar que políticas
              específicas podem variar dependendo do fornecedor de serviços,
              como companhias aéreas, hotéis ou empresas de transporte. Nossa
              equipe estará disponível para auxiliá-lo e fornecer orientações
              adequadas para lidar com qualquer solicitação de alteração ou
              cancelamento, de acordo com as políticas aplicáveis.
            </div>
          </div>
        </div>
      </div>
    </section>
  );
};

export default CardInformacoes;
