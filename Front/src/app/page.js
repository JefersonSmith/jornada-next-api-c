import Busca from "./components/Busca";
import CardInformacoes from "./components/CardInformacoes";
import CardPromo from "./components/CardPromo";
import Carrossel from "./components/Carrossel";
import 'bootstrap/dist/css/bootstrap.min.css';


const Home = () => {
  return (
    <div>
      <Carrossel />
      <Busca />


      <div class="container row mx-auto">
        <CardPromo
          imagem="/produtos/1.png"
          descricao="Balneário Camboriú é uma cidade no estado de Santa Catarina, no sul
        do Brasil. Um dos destinos turísticos mais populares do país"
          cidade="Balneário Camboriú"
          valor="R$ 599,90"
        />

        <CardPromo
          imagem="/produtos/2.png"
          descricao="O Rio de Janeiro é uma grande cidade brasileira à beira-mar, famosa pelas praias de Copacabana e Ipanema."
          cidade="Rio de Janeiro"
          valor="R$ 599,90"
        />

        <CardPromo
          imagem="/produtos/3.png"
          descricao="Bali é uma ilha da Indonésia conhecida por suas montanhas vulcânicas repletas de florestas e paisagens exuberantes."
          cidade="Bali"
          valor="R$ 7890,00"
        />

        <CardPromo
          imagem="/produtos/4.png"
          descricao="Jericoacoara é uma vila que faz parte de Jijoca de Jericoacoara, no Ceará, Nordeste do Brasil."
          cidade="Jericoacoara"
          valor="R$ 999,90"
        />

        <CardPromo
          imagem="/produtos/5.png"
          descricao="Paris, a capital da França, é uma importante cidade europeia e um centro mundial de arte"
          cidade="Paris"
          valor="R$ 599,90"
        />

        <CardPromo
          imagem="/produtos/6.png"
          descricao="As Maldivas são uma nação tropical no Oceano Índico composta por 26 atóis em formato de anel."
          cidade="Maldivas"
          valor="R$ 1599,90"
        />
      </div>
      <CardInformacoes />
    </div>
  );
};

export default Home;
