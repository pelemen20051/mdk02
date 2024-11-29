using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Jack
{

    public partial class Form1 : Form
    {
        private List<Card> deck; // Колода карт
        private List<Card> playerHand; // Карты игрока
        private int balance = 1000; // Баланс игрока
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void InitializeGame()
        {
            deck = GenerateDeck();
            playerHand = new List<Card>();
            lblBalance.Text = $"Баланс: {balance}";
            UpdateDeckInfo();
        }

        private List<Card> GenerateDeck()
        {
            var deck = new List<Card>();
            string[] suits = { "♠", "♥", "♦", "♣" };
            for (int i = 1; i <= 13; i++)
            {
                foreach (var suit in suits)
                {
                    int value = i > 10 ? 10 : i; // Валет, дама, король = 10
                    deck.Add(new Card { Value = value, Suit = suit, Name = i == 1 ? "Туз" : i.ToString() });
                }
            }
            return deck;
        }

        private void btnDrawCard_Click(object sender, EventArgs e)
        {
            if (deck.Count == 0)
            {
                MessageBox.Show("В колоде больше нет карт!");
                return;
            }

            var card = DrawCard();
            playerHand.Add(card);
            UpdatePlayerHand();
            CheckForAceLogic();
        }
        private Card DrawCard()
        {
            int index = random.Next(deck.Count);
            var card = deck[index];
            deck.RemoveAt(index);
            UpdateDeckInfo();
            return card;
        }


        private void UpdateDeckInfo()
        {
            int remainingPoints = deck.Sum(c => c.Value == 1 ? 11 : c.Value);
            lblDeckInfo.Text = $"Осталось карт: {deck.Count}, Очков: {remainingPoints}";
        }

        private void UpdatePlayerHand()
        {
            lstPlayerHand.Items.Clear();
            foreach (var card in playerHand)
            {
                lstPlayerHand.Items.Add($"{card.Name} {card.Suit}");
            }
            lblPlayerScore.Text = $"Очки: {CalculateScore(playerHand)}";
        }

        private int CalculateScore(List<Card> hand)
        {
            int score = 0;
            int aceCount = hand.Count(c => c.Value == 1);

            foreach (var card in hand)
            {
                score += card.Value == 1 ? 11 : card.Value;
            }

            while (score > 21 && aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }

            return score;
        }

        private void CheckForAceLogic()
        {
            int score = CalculateScore(playerHand);
            if (score > 21)
            {
                MessageBox.Show("Перебор! Вы проиграли!");
                ResetGame();
            }
        }

        private void ResetGame()
        {
            playerHand.Clear();
            deck = GenerateDeck();
            UpdateDeckInfo();
            UpdatePlayerHand();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnRemoveCard_Click(object sender, EventArgs e)
        {
            if (lstPlayerHand.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите карту для удаления.");
                return;
            }

            int index = lstPlayerHand.SelectedIndex;
            playerHand.RemoveAt(index);
            UpdatePlayerHand();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            int bet = (int)numBet.Value;
            if (bet > balance)
            {
                MessageBox.Show("Недостаточно средств!");
                return;
            }

            balance -= bet;
            lblBalance.Text = $"Баланс: {balance}";
        }
        public class Card
        {
            public int Value { get; set; }
            public string Suit { get; set; }
            public string Name { get; set; }
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }
    }

    
}
