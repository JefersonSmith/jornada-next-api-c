import styles from "./card.module.css";

export default async function Card() {
  const cards = await fetch("http://localhost:5056/api/Jornada").then((res) =>
    res.json()
  );

  console.log(cards);
  return (
    <div className={styles.container}>
      {cards?.map((card) => (
        <div className={styles.card} key={card.id}>
          <img src={card.destinoURL} alt={card.city} />
          <div className={styles.card_title}>
            <p>{card.city} / {card.country}</p>
            <p>R${card.price}</p>
          </div>
        </div>
      ))}
    </div>
  );
}
