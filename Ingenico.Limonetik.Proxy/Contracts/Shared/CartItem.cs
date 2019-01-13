using System;
using System.ComponentModel.DataAnnotations;

namespace Ingenico.Limonetik.Proxy.Contracts.Shared
{
    /// <summary>
    /// Detailed information on one shopping cart item (in a CartItems object)
    /// </summary>
    public class CartItem
    {
        /// <summary>
        /// Article identifier used by the retailer
        /// </summary>
        /// <example>R49203</example>
        [MaxLength(200)]
        public string Id { get; set; }

        /// <summary>
        /// Retailer's description of the article
        /// </summary>
        /// <example></example>
        [MaxLength(200)]
        public string Label { get; set; }

        /// <summary>
        /// Article unit price
        /// </summary>
        /// <example>65.00</example>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Tax amount
        /// </summary>
        /// <example>13.00</example>
        public decimal VAT { get; set; }

        /// <summary>
        /// Article quantity in the shopping cart
        /// </summary>
        /// <example>1</example>
        public int Quantity { get; set; }

        /// <summary>
        /// Category Limonetik's product category
        /// </summary>
        /// <remarks>
        /// Accepted values: ComputersAndSoftware / Electronics / Phones / Appliances / HomeAndGarden / Fashion / HealthAndBeauty / Jewellery / Sport / LeisureAndHobbies / CarsAndMotorbikes / Furniture / / KidsAndBaby / VideoGamesAndConsoles / ToysAndGames / Pets / FoodAndDrink / GiftAndFlowers / Entertainment / Travel / AuctionsAndGroupBuying / ServicesForIndividuals / ServicesForProfessionals
        /// </remarks>
        /// <example>LeisureAndHobbies</example>
        [MaxLength(100)]
        [RegularExpression("ComputersAndSoftware|Electronics|Phones|Appliances|HomeAndGarden|Fashion|HealthAndBeauty|Jewellery|Sport|LeisureAndHobbies|CarsAndMotorbikes|Furniture|KidsAndBaby|VideoGamesAndConsoles|ToysAndGames|Pets|FoodAndDrink|GiftAndFlowers|Entertainment|Travel|AuctionsAndGroupBuying|ServicesForIndividuals|ServicesForProfessionals")]
        public string Category { get; set; }

        /// <summary>
        /// Main retail category with which the article is associated
        /// </summary>
        /// <example>598</example>
        [MaxLength(100)]
        public string MerchantCategory1 { get; set; }

        /// <summary>
        /// Secondary retail category with which the article is associated
        /// </summary>
        /// <example>MP3 Players</example>
        [MaxLength(100)]
        public string MerchantCategory2 { get; set; }

        /// <summary>
        /// Article brand
        /// </summary>
        /// <example>Microsoft</example>
        [MaxLength(100)]
        public string Brand { get; set; }

        /// <summary>
        /// Article URL
        /// </summary>
        /// <example></example>
        [MaxLength(2083)]
        public string Url { get; set; }

        /// <summary>
        /// Delivery method
        /// </summary>
        /// <example>MP3 Players</example>
        public Delivery Delivery { get; set; }

        /// <summary>
        /// Free text field
        /// </summary>
        /// <example></example>
        [MaxLength(500)]
        public string RawCustom { get; set; }
    }

    public class Delivery
    {
        /// <summary>
        /// Delivery type
        /// </summary>
        /// <remarks>
        /// Accepted values:
        ///  - StorePickup
        ///  - NetworkPickup
        ///  - TravelPickup
        ///  - Carrier
        ///  - EDelivery
        ///  - Other
        ///</remarks>        
        [MaxLength(20)]
        [RegularExpression("StorePickup|NetworkPickup|TravelPickup|Carrier|EDelivery|Other")]
        public string Type { get; set; }

        /// <summary>
        /// Delivery type name
        /// </summary>
        /// <example>COLISSIMO</example>
        [MaxLength(20)]
        public string Label { get; set; }

        /// <summary>
        /// Delivery lead time
        /// </summary>
        /// <remarks>
        /// Accepted values: Express (within 48 hours or less) / Standard (other)</remarks>
        /// <example>Standard</example>
        [MaxLength(20)]
        [RegularExpression("Express|Standard")]
        public string Speed { get; set; }

        /// <summary>
        /// Expected delivery date
        /// </summary>
        /// <example>2013-06-11T16:32:11Z</example>
        [MaxLength(20)]
        public DateTime ExpectedDate { get; set; }

        /// <summary>
        /// Number of days allowed for delivery
        /// </summary>
        /// <example>15</example>
        public int ExpectedDelay { get; set; }

        /// <summary>
        /// Free text field
        /// </summary>
        [MaxLength(500)]
        public string RawCustom { get; set; }
    }
}