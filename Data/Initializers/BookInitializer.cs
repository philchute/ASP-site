using ASP_site.Models;
using System.Collections.Generic;

namespace ASP_site.Data.Initializers
{
    public static class BookInitializer
    {
        public static (List<Book> books, List<Link> links) GetData()
        {
            var books = new List<Book>
            {
                new Book
                {
                    Title = "A Bathroom of Her Own",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1946,
                    Type = BookType.ShortStory,
                    Description = "This short story is political, like much of his non-fiction writing.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" }
                    }
                },
                new Book
                {
                    Title = "All You Zombies",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1959,
                    Type = BookType.ShortStory,
                    Description = "Made into the movie 'Predestination' by the Spierig Brothers in 2014 starring Ethan Hawke, Sarah Snook, and Noah Taylor.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" },
                        new Tag { Name = "Collection: The Unpleasant Profession of Jonathan Hoag (6xH)" }
                    }
                },
                new Book
                {
                    Title = "And He Built a Crooked House",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" },
                        new Tag { Name = "Collection: The Unpleasant Profession of Jonathan Hoag (6xH)" }
                    }
                },
                new Book
                {
                    Title = "Between Planets",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1951,
                    Type = BookType.Novel,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: To The Stars" }
                    }
                },
                new Book
                {
                    Title = "Beyond Doubt",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Lyle Monroe with Elma Wentz",
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Beyond This Horizon",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Anson MacDonald",
                    PublicationYear = 1948,
                    Type = BookType.Novel,
                    Description = "2018 Hugo Award (Retro Hugos: Novel): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Robert Heinlein Omnibus" }
                    }
                },
                new Book
                {
                    Title = "The Black Pits of Luna",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1948,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Blowups Happen",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1940,
                    Type = BookType.ShortStory,
                    Description = "2016 Hugo Award (Retro Hugos: Novelette): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Worlds of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Man Who Sold the Moon" }
                    }
                },
                new Book
                {
                    Title = "The Bulletin Board",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "R. A. Heinlein",
                    PublicationYear = 1951,
                    Type = BookType.ShortStory,
                    Description = "Was one of Heinlein's short stories in Calling All Girls magazine, first published in 1951.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Requiem" }
                    },
                },
                new Book
                {
                    Title = "By His Bootstraps",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Anson MacDonald",
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "The Cat Who Walks Through Walls",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1985,
                    Type = BookType.Novel,
                    Description = "1986 Locus Award (SF Novel): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "World as Myth" }
                    }
                },
                new Book
                {
                    Title = "Citizen of the Galaxy",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1957,
                    Type = BookType.Novel,
                    Description = "2022 Prometheus Award (Hall of Fame): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Infinite Possibilities" }
                    }
                },
                new Book
                {
                    Title = "Cliff and the Calories",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "R. A. Heinlein",
                    PublicationYear = 1950,
                    Type = BookType.ShortStory,
                    Description = "One of Heinlein's few stories for girls, set in then modern times, first published in Calling All Girls magazine in 1950.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Columbus Was a Dope",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Lyle Monroe",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Common Sense",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Coventry",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1940,
                    Type = BookType.ShortStory,
                    Description = "2016 Hugo Award (Retro Hugos: Novella): Nominated, 2017 Prometheus Award (Hall of Fame Award): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: Revolt in 2100" }
                    }
                },
                new Book
                {
                    Title = "Delilah and the Space Rigger",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Destination Moon",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1950,
                    Type = BookType.ShortStory,
                    Description = "Heinlein contributed to the screenplay of the 1950 movie Destination Moon.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: Requiem" }
                    }
                },
                new Book
                {
                    Title = "The Door into Summer",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1957,
                    Type = BookType.Novel,
                    Description = "Adapted into a Japanese movie in 2021.",            
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: A Heinlein Trio" }
                    }
                },
                new Book
                {
                    Title = "Double Star",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1956,
                    Type = BookType.Novel,
                    Description = "1956 Hugo Award (Novel): Won, 1987 Locus Award (All-Time Best SF Novel): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: A Heinlein Trio" }
                    }
                },
                new Book
                {
                    Title = "Elsewhen",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Caleb Saunders",
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Elsewhere",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Assignment in Eternity" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Farmer in the Sky",    
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1950,
                    Type = BookType.Novel,
                    Description = "Won the 2001 Retro Hugo for best novel. Initially serialized in a condensed version in Boys' Life magazine as Satellite Scout",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Four Frontiers" }
                    }
                },
                new Book
                {
                    Title = "Farnham's Freehold",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1964,
                    Type = BookType.Novel
                },
                new Book
                {
                    Title = "Field Defects: Memo from a Cyborg",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1975,
                    Type = BookType.ShortStory,
                    Description = "Written in 1975, published in 2010 in the Virginia Collection and then in May 2015 Galaxy magazine.",
                },
                new Book
                {
                    Title = "For Us, the Living: A Comedy of Customs",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2003,
                    Type = BookType.Novel,
                    Description = "Heinlein's first novel, written in 1938, but wasn't published until 2003.",
                },
                new Book
                {
                    Title = "Free Men",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1946,
                    Type = BookType.ShortStory,
                    Description = "Published in 1966, 2023 Prometheus Award (Hall of Fame Award): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Worlds of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book 
                {
                    Title = "Friday",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1982,
                    Type = BookType.Novel,
                    Description = "1983 Locus Award (SF Novel): Nominated, 1983 Hugo Award (Novel): Nominated, 1983 Nebula Award (Novel): Nominated, 1983 Prometheus Award (Novel): Nominated"
                },
                new Book
                {
                    Title = "Gentlemen, Be Seated!",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1948,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Glory Road",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1964,
                    Type = BookType.Novel,
                    Description = "1964 Hugo Award (Novel): Nominated, 1987 Locus Award (All-Time Best SF Novel): Nominated"
                },
                new Book
                {
                    Title = "Goldfish Bowl",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Anson MacDonald",
                    PublicationYear = 1942,
                    Type = BookType.ShortStory,
                    Description = "2018 Hugo Award (Retro Hugos: Novelette): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {   
                    Title = "The Green Hills of Earth",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "1952 Analog Award (All-Time Best Book): 8th Place",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" },
                        new Tag { Name = "Collection: The Robert Heinlein Omnibus" }
                    }
                },
                new Book
                {
                    Title = "Grumbles from the Grave",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "Posthumous Autobiography, 1990 Locus Award (Non-Fiction): Won, 1990 Hugo Award (Best Related Work): Nominated"
                },
                new Book
                {
                    Title = "Gulf",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Assignment in Eternity" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "The Happy Days Ahead",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Have Space Suit—Will Travel",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1958,
                    Type = BookType.Novel,
                    Description = "1959 Hugo Award (Novel): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Outward Bound" }
                    }
                },
                new Book
                {
                    Title = "How to be a Survivor",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" }
                    },
                },
                new Book
                {
                    Title = "I Will Fear No Evil",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1970,
                    Type = BookType.Novel,
                    Description = "1971 Locus Award (Novel): Nominated, 1978 Seiun Award (Translated Long Work): Won"
                },
                new Book
                {
                    Title = "If This Goes On—",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1940,
                    Type = BookType.ShortStory,
                    Description = "First novel, 2016 Hugo Award (Retro Hugos: Novella): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: Revolt in 2100" }
                    }
                },
                new Book
                {
                    Title = "Inside Intourist",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "It's Great to Be Back!",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Jerry Was a Man",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "Made for TV as episode 3 of 'Masters of Science Fiction'.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: Assignment in Eternity" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Job: A Comedy of Justice",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1984,
                    Type = BookType.Novel,
                    Description = "1985 Hugo Award (Novel): Nominated, 1985 Locus Award (Fantasy Novel): Won, 1985 Nebula Award (Novel): Nominated"
                },
                new Book
                {
                    Title = "Larger than Life: A Tribute to E. E. \"Doc\" Smith",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "The Last Days of the United States",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" }
                    },
                },
                new Book
                {
                    Title = "Let There Be Light",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Lyle Monroe",
                    PublicationYear = 1940,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: The Man Who Sold the Moon" }
                    }
                },
                new Book
                {
                    Title = "Life-Line",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1939,
                    Type = BookType.ShortStory,
                    Description = "Heinlein's first published story, first published in Astounging Magazine in 1939.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Worlds of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Man Who Sold the Moon" }
                    }
                },
                new Book
                {
                    Title = "Logic of Empire",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "The Long Watch",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1948,
                    Type = BookType.ShortStory,
                    Description = "Originally titled 'Rebellion on the Moon', appeared in American Legion Magazine in 1949, then Nebula Science Fiction in 1955. Connected more with 'Space Cadet' than other Future History. Referenced in Starship Troopers.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Lost Legacy",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Lost Legion",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Assignment in Eternity" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Magic, Inc.",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1940,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. The Devil Makes the Law, 2016 Hugo Award (Retro Hugos: Novella): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Three by Heinlein" },
                        new Tag { Name = "Collection: Waldo & Magic, Inc." }
                    }
                },
                new Book
                {
                    Title = "The Man Who Sold the Moon",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1950,
                    Type = BookType.ShortStory,
                    Description = "1952 Analog Award (All-Time Best Book): 4th Place, 2001 Hugo Award (Retro Hugos: Novella): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Man Who Sold the Moon" },
                        new Tag { Name = "Collection: The Robert Heinlein Omnibus" }
                    },
                },
                new Book
                {
                    Title = "The Man Who Sold the Moon (Collection)",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1950,
                    Type = BookType.Forward,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Man Who Sold the Moon" }
                    }
                },
                new Book
                {
                    Title = "The Man Who Traveled in Elephants",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. The Elephant Circuit",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Unpleasant Profession of Jonathan Hoag (6xH)" },
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" }
                    }
                },
                new Book
                {
                    Title = "The Menace from Earth",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" }
                    }
                },
                new Book
                {
                    Title = "Methuselah's Children",
                    Author = "Robert A. Heinlein",  
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "Lengthened and published as a novel in 1958",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" }
                    }
                },
                new Book
                {
                    Title = "Methuselah's Children (Novel)",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1958,
                    Type = BookType.Novel,
                    Description = "Originally a serialized novella in 1941, 1997 Prometheus Award (Hall of Fame Award): Won"
                },
                new Book
                {
                    Title = "Misfit",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1939,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: Revolt in 2100" }
                    }
                },
                new Book
                {
                    Title = "The Moon Is a Harsh Mistress",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1966,
                    Type = BookType.Novel,
                    Description = "1967 Hugo Award (Novel): Won, 1975 Locus Award (All-Time Best Novel): Nominated, 1967 Nebula Award (Novel): Nominated, 1983 Prometheus Award (Hall of Fame Award): Won, 1987 Locus Award (All-Time Best SF Novel): Nominated"
                },
                new Book
                {
                    Title = "My Object All Sublime",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Lyle Monroe",
                    PublicationYear = 1942,
                    Type = BookType.ShortStory,
                    Description = "Heinlein did not include this story in any collections during his lifetime",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "No Bands Playing, No Flags Flying",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.NonFiction,
                    Description = "Written in 1947, published in 1973",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" }
                    },
                },
                new Book
                {
                    Title = "The Notebooks of Lazarus Long",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1978,
                    Type = BookType.ShortStory,
                    Description = "Exceprts from the novel Time Enough for Love."
                },
                new Book
                {
                    Title = "Nothing Ever Happens on the Moon",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "The Number of the Beast",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1981,
                    Type = BookType.Novel,
                    Description = "1981 Locus Award (SF Novel): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "World as Myth" }
                    }
                },
                new Book
                {
                    Title = "On the Slopes of Vesuvius",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    },
                },
                new Book
                {
                    Title = "Ordeal in Space",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1948,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Orphans of the Sky",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1963,
                    Type = BookType.Novel,
                    Description = "Fix-up novel comprising the novellas Universe and Common Sense, both originally published in 1941"
                },
                new Book
                {
                    Title = "Our Fair City",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1948,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" },
                        new Tag { Name = "Collection: The Unpleasant Profession of Jonathan Hoag (6xH)" }
                    }
                },
                new Book
                {
                    Title = "Pandora's Box",
                    Author = "Robert A. Heinlein",
                    Type = BookType.Forward,
                    Description = "",
                    PublicationYear = 1966,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Worlds of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Paul Dirac, Anitmatter, and You",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1952,
                    Type = BookType.NonFiction,
                    Description = "Two articles for Encyclopædia Britannica on Paul Dirac and antimatter, and on blood chemistry.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Pie From the Sky",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" }
                    },
                },
                new Book
                {
                    Title = "Pied Piper",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Lyle Monroe",
                    PublicationYear = 1942,
                    Type = BookType.ShortStory,
                    Description = "Heinlein did not include this story in any collections during his lifetime",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    },
                },
                new Book
                {
                    Title = "Podkayne of Mars",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1963,
                    Type = BookType.Novel,
                    Description = "Based on his character Maureen from the Puddin' series he wrote for girls. Republished in 1995 with an alternate ending.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Outward Bound" }
                    }
                },
                new Book
                {
                    Title = "Poor Daddy",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "R. A. Heinlein",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "This one one of Heinlein's few stories for girls, set in then modern times, first published in Calling All Girls magazine in 1949.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Requiem" }
                    }
                },
                new Book
                {
                    Title = "The Pragmatics of Patriotism",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Pravda Means Truth",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Project Nightmare",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1953,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "The Puppet Masters",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1951,
                    Type = BookType.Novel,
                    Description = "Re-published posthumously with excisions restored, 1990. Made into a movie in 1994 starring Donald Sutherland.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: Three by Heinlein" },
                        new Tag { Name = "Collection: A Heinlein Trio" }
                    }
                },
                new Book
                {
                    Title = "The Pursuit of the Pankera",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2020,
                    Type = BookType.Novel,
                    Description = "Previously unpublished, this is an alternate version of The Number of the Beast, the first third is the same.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "World as Myth" }
                    }
                },
                new Book
                {
                    Title = "Ray Guns and Rocket Ships",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Red Planet",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1949,
                    Type = BookType.Novel,
                    Description = "Addapted into a children's animated TV series in 1994. 1996 Prometheus Award (Hall of Fame): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: Four Frontiers" }
                    }
                },
                new Book
                {
                    Title = "Requiem",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1940,
                    Type = BookType.ShortStory,
                    Description = "2003 Prometheus Award (Hall of Fame Award): Won, 2016 Hugo Award (Retro Hugos: Short Story): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Man Who Sold the Moon" },
                        new Tag { Name = "Collection: Requiem" }
                    },
                },
                new Book
                {
                    Title = "The Roads Must Roll",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1940,
                    Type = BookType.ShortStory,
                    Description = "2016 Hugo Award (Retro Hugos: Novelette): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Man Who Sold the Moon" }
                    }
                },
                new Book
                {
                    Title = "Rocket Ship Galileo",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.Novel,
                    Description = "A story of three boys who travel to the Moon.",
                    Tags = new List<Tag> 
                    { 
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Four Frontiers" }
                    }
                },
                new Book
                {
                    Title = "The Rolling Stones",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1952,
                    Type = BookType.Novel,
                    Description = "a.k.a. Space Family Stone / 2006 Audie Awards (Science Fiction): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: To The Stars" }
                    }
                },
                new Book
                {
                    Title = "Searchlight",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Worlds of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" }
                    }
                },
                new Book
                {
                    Title = "Shooting Destination Moon",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1950,
                    Type = BookType.NonFiction,
                    Description = "First appeared in July 1950 Astounding Science Fiction magazine.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Requiem" }
                    },
                },
                new Book
                {
                    Title = "Sixth Column",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1949,
                    Type = BookType.Novel,
                    Description = "a.k.a. The Day After Tomorrow / Initially serialized in 1941, and at that time credited to Anson MacDonald."
                },
                new Book
                {
                    Title = "Sky Lift",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1953,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Solution Unsatisfactory",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Anson MacDonald",
                    PublicationYear = 1940,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Worlds of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Space Cadet",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1948,
                    Type = BookType.Novel,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Four Frontiers" }
                    },
                    Description = ""
                },
                new Book
                {
                    Title = "Space Jockey",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Spinoff",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1980,
                    Type = BookType.NonFiction,
                    Description = "An article based on Heinlein's testimony to the US Congress about the commercialization of inventions created for NASA and the American space program. Published in Omni magazine in 1980; reprinted in Expanded Universe.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "The Star Beast",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1954,
                    Type = BookType.Novel,
                    Description = "2008 Audie Awards (Audio Drama): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: To The Stars" }
                    }
                },
                new Book
                {
                    Title = "Starman Jones",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1953,
                    Type = BookType.Novel,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: To The Stars" }
                    }
                },
                new Book
                {
                    Title = "Starship Troopers",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1959,
                    Type = BookType.Novel,
                    Description = "Won the 1960 Hugo Award for Best Novel. Heinlein considered this a Juvenile novel, but opinions vary. Made into a movie by Paul Verhoeven in 1997 starring Denise Richards, Casper Van Dien, and Dina Meyer.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: Outward Bound" }
                    }
                },
                new Book
                {
                    Title = "Stranger in a Strange Land",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1961,
                    Type = BookType.Novel,
                    Description = "Reprinted at the original greater length in 1991, 1962 Hugo Award (Novel): Won, 1975 Locus Award (All-Time Best Novel): Nominated, 1987 Prometheus Award (Hall of Fame Award): Won, 1987 Locus Award (All-Time Best SF Novel): Nominated, 1990 Science Fiction Book Club's Book of the Year Award: Nominated"
                },
                new Book
                {
                    Title = "Successful Operation",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Lyle Monroe",
                    PublicationYear = 1940,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Heil!",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    },
                },
                new Book
                {
                    Title = "Take Back Your Government: A Practical Handbook for the Private Citizen",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1992,
                    Type = BookType.NonFiction,
                    Description = "Originally published as How to Be a Politician"
                },
                new Book
                {
                    Title = "A Tenderfoot in Space",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1956,
                    Type = BookType.ShortStory,
                    Description = "Serialized in 1958",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: Requiem" }
                    }
                },
                new Book
                {
                    Title = "They",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" },
                        new Tag { Name = "Collection: The Unpleasant Profession of Jonathan Hoag (6xH)" }
                    }
                },
                new Book
                {
                    Title = "They Do It with Mirrors",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Simon York",
                    PublicationYear = 1947,
                    Type = BookType.NonFiction,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" }
                    },
                },
                new Book
                {
                    Title = "The Third Millennium Open",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Time Enough for Love",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1973,
                    Type = BookType.Novel,
                    Description = "1974 Locus Award (SF Novel): Nominated, 1974 Hugo Award (Novel): Nominated, 1974 Nebula Award (Novel): Nominated, 1983 Prometheus Award (Novel): Nominated"
                },
                new Book
                {
                    Title = "Time for the Stars",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1956,
                    Type = BookType.Novel,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Infinite Possibilities" }
                    }
                },
                new Book
                {
                    Title = "To Sail Beyond the Sunset",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1987,
                    Type = BookType.Novel,
                    Description = "1988 Locus Award (SF Novel): Nominated, 1989 Prometheus Award (Novel): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "World as Myth" }
                    }
                },
                new Book
                {
                    Title = "Tomorrow, the Stars",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1952,
                    Type = BookType.Forward,
                    Description = "Anthology of stories by 14 authors selected by Frederik Pohl and Judith Merril, foreword by Heinlein who got his name on the cover."
                },
                new Book
                {
                    Title = "Tramp Royale",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1992,
                    Type = BookType.NonFiction,
                    Description = "Heinlein's travelogue from travelling in the 50s."
                },
                new Book
                {
                    Title = "Tunnel in the Sky",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1955,
                    Type = BookType.Novel,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Infinite Possibilities" }
                    }
                },
                new Book
                {
                    Title = "Universe",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" }
                    }
                },
                new Book
                {
                    Title = "The Unpleasant Profession of Jonathan Hoag",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "John Riverside",
                    PublicationYear = 1942,
                    Type = BookType.ShortStory,
                    Description = "2018 Hugo Award (Retro Hugos: Novella): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" },
                        new Tag { Name = "Collection: The Unpleasant Profession of Jonathan Hoag (6xH)" }
                    }
                },
                new Book
                {
                    Title = "Variable Star",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2006,
                    Type = BookType.Novel,
                    Description = "With Spider Robinson; Heinlein's eight page outline written in 1955; Robinson's full novel from the outline appeared in 2006"
                },
                new Book
                {
                    Title = "Waldo",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Anson MacDonald",
                    PublicationYear = 1942,
                    Type = BookType.ShortStory,
                    Description = "2018 Hugo Award (Retro Hugos: Novella): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Three by Heinlein" },
                        new Tag { Name = "Collection: Waldo & Magic, Inc." }
                    }
                },
                new Book
                {
                    Title = "Water Is for Washing",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "We Also Walk Dogs",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Anson MacDonald",
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Where To?",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1952,
                    Type = BookType.NonFiction,
                    Description = "Galaxy magazine, 1950, 1965, 1980",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    }
                },
                new Book
                {
                    Title = "Who are the Heirs of Patrick Henry?",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    PublicationYear = 1958,
                    Description = "Printed as a paid ad in Colorado Springs Gazette in 1958.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "The Witch's Daughters",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1946,
                    Type = BookType.Poem,
                    Description = "First published in New Destinies vol VI in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Requiem" }
                    },
                },
                new Book
                {
                    Title = "The Year of the Jackpot",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1952,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Dance Session",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1946,
                    Type = BookType.Poem,
                    Description = "Love poem",
                },
                new Book
                {
                    Title = "The Green Hills of Earth (Poem)",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2003,
                    Type = BookType.Poem,
                    Description = "",
                },
                new Book
                {
                    Title = "Atlantis",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2007,
                    Type = BookType.Poem,
                    Description = "",
                },
                new Book
                {
                    Title = "The Last Adventure",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2007,
                    Type = BookType.Poem,
                    Description = "",
                },
                new Book
                {
                    Title = "Brave New World",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2011,
                    Type = BookType.Poem,
                    Description = "",
                },
                new Book
                {
                    Title = "Death Song of a Wood's Colt",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2011,
                    Type = BookType.Poem,
                    Description = "This poem is used 14 years after it was written in Stranger in a Strange Land with one line changed: instead of My sandy burning eyeballs, as the light within them dims of the original, Stranger uses, sanded burning eyeballs, as light within them dims.",
                },
                new Book
                {
                    Title = "Three Wise Mice",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2011,
                    Type = BookType.Poem,
                    Description = "",
                },
                new Book
                {
                    Title = "Untitled Poem Fragment",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2011,
                    Type = BookType.Poem,
                    Description = "",
                },
                new Book
                {
                    Title = "Encyclopædia Britannica",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1952,
                    Type = BookType.NonFiction,
                    Description = "Two articles for Encyclopædia Britannica on Paul Dirac and antimatter, and on blood chemistry.",
                }
            };

            var links = new List<Link>
            {
                new Link { BookTitle = "A Bathroom of Her Own", Url = "https://en.wikipedia.org/wiki/A_Bathroom_of_Her_Own", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "All You Zombies", Url = "https://en.wikipedia.org/wiki/%27%E2%80%94All_You_Zombies%E2%80%94%27", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "And He Built a Crooked House", Url = "https://en.wikipedia.org/wiki/And_He_Built_a_Crooked_House", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Between Planets", Url = "https://en.wikipedia.org/wiki/Between_Planets", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Beyond Doubt", Url = "https://en.wikipedia.org/wiki/Beyond_Doubt", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Beyond This Horizon", Url = "https://en.wikipedia.org/wiki/Beyond_This_Horizon", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Black Pits of Luna", Url = "https://en.wikipedia.org/wiki/The_Black_Pits_of_Luna", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Blowups Happen", Url = "https://en.wikipedia.org/wiki/Blowups_Happen", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "By His Bootstraps", Url = "https://en.wikipedia.org/wiki/By_His_Bootstraps", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Cat Who Walks Through Walls", Url = "https://en.wikipedia.org/wiki/The_Cat_Who_Walks_Through_Walls", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Citizen of the Galaxy", Url = "https://en.wikipedia.org/wiki/Citizen_of_the_Galaxy", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Columbus Was a Dope", Url = "https://en.wikipedia.org/wiki/Columbus_Was_a_Dope", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Coventry", Url = "https://en.wikipedia.org/wiki/Coventry_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Delilah and the Space Rigger", Url = "https://en.wikipedia.org/wiki/Delilah_and_the_Space_Rigger", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Destination Moon", Url = "https://en.wikipedia.org/wiki/Destination_Moon_(story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Door into Summer", Url = "https://en.wikipedia.org/wiki/The_Door_into_Summer", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Double Star", Url = "https://en.wikipedia.org/wiki/Double_Star", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Elsewhen", Url = "https://en.wikipedia.org/wiki/Elsewhen", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Farmer in the Sky", Url = "https://en.wikipedia.org/wiki/Farmer_in_the_Sky", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Farnham's Freehold", Url = "https://en.wikipedia.org/wiki/Farnham%27s_Freehold", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "For Us, the Living: A Comedy of Customs", Url = "https://en.wikipedia.org/wiki/For_Us,_the_Living:_A_Comedy_of_Customs", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Free Men", Url = "https://en.wikipedia.org/wiki/Free_Men", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Friday", Url = "https://en.wikipedia.org/wiki/Friday_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Gentlemen, Be Seated!", Url = "https://en.wikipedia.org/wiki/Gentlemen,_Be_Seated!", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Glory Road", Url = "https://en.wikipedia.org/wiki/Glory_Road", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Goldfish Bowl", Url = "https://en.wikipedia.org/wiki/Goldfish_Bowl", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Green Hills of Earth", Url = "https://en.wikipedia.org/wiki/The_Green_Hills_of_Earth", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Grumbles from the Grave", Url = "https://en.wikipedia.org/wiki/Grumbles_from_the_Grave", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Gulf", Url = "https://en.wikipedia.org/wiki/Gulf_(novella)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Have Space Suit—Will Travel", Url = "https://en.wikipedia.org/wiki/Have_Space_Suit%E2%80%94Will_Travel", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "I Will Fear No Evil", Url = "https://en.wikipedia.org/wiki/I_Will_Fear_No_Evil", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "If This Goes On—", Url = "https://en.wikipedia.org/wiki/%22If_This_Goes_On%E2%80%94%22", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "It's Great to Be Back!", Url = "https://en.wikipedia.org/wiki/It%27s_Great_to_Be_Back!", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Jerry Was a Man", Url = "https://en.wikipedia.org/wiki/Jerry_Was_a_Man", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Jerry Was a Man", Url = "https://www.youtube.com/watch?v=aJHiOiMKzX4&pp=ygUPamVycnkgd2FzIGEgbWFu", Label = "Masters of Science Fiction: Jerry Was a Man", Description = "Masters of Science Fiction: Jerry Was a Man", LinkType = LinkType.Video },
                new Link { BookTitle = "Job: A Comedy of Justice", Url = "https://en.wikipedia.org/wiki/Job:_A_Comedy_of_Justice", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Let There Be Light", Url = "https://en.wikipedia.org/wiki/Let_There_Be_Light_(Heinlein_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Life-Line", Url = "https://en.wikipedia.org/wiki/Life-Line", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Logic of Empire", Url = "https://en.wikipedia.org/wiki/Logic_of_Empire", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Long Watch", Url = "https://en.wikipedia.org/wiki/The_Long_Watch", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Lost Legacy", Url = "https://en.wikipedia.org/wiki/Lost_Legacy", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Magic, Inc.", Url = "https://en.wikipedia.org/wiki/Magic,_Inc.", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Man Who Sold the Moon (Collection)", Url = "https://en.wikipedia.org/wiki/The_Man_Who_Sold_the_Moon_(short_story_collection)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Man Who Traveled in Elephants", Url = "https://en.wikipedia.org/wiki/The_Man_Who_Traveled_in_Elephants", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Menace from Earth", Url = "https://en.wikipedia.org/wiki/The_Menace_from_Earth", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Methuselah's Children (Novel)", Url = "https://en.wikipedia.org/wiki/Methuselah%27s_Children", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Misfit", Url = "https://en.wikipedia.org/wiki/Misfit_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Moon Is a Harsh Mistress", Url = "https://en.wikipedia.org/wiki/The_Moon_Is_a_Harsh_Mistress", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "My Object All Sublime", Url = "https://en.wikipedia.org/wiki/My_Object_All_Sublime", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Nothing Ever Happens on the Moon", Url = "https://en.wikipedia.org/wiki/Nothing_Ever_Happens_on_the_Moon", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Number of the Beast", Url = "https://en.wikipedia.org/wiki/The_Number_of_the_Beast_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Ordeal in Space", Url = "https://en.wikipedia.org/wiki/Ordeal_in_Space", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Orphans of the Sky", Url = "https://en.wikipedia.org/wiki/Orphans_of_the_Sky", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Our Fair City", Url = "https://en.wikipedia.org/wiki/Our_Fair_City", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Podkayne of Mars", Url = "https://en.wikipedia.org/wiki/Podkayne_of_Mars", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Poor Daddy", Url = "https://en.wikipedia.org/wiki/Poor_Daddy", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Project Nightmare", Url = "https://en.wikipedia.org/wiki/Project_Nightmare", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Puppet Masters", Url = "https://en.wikipedia.org/wiki/The_Puppet_Masters", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Pursuit of the Pankera", Url = "https://en.wikipedia.org/wiki/The_Number_of_the_Beast_(novel)#The_Pursuit_of_the_Pankera", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Red Planet", Url = "https://en.wikipedia.org/wiki/Red_Planet_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Red Planet", Url = "https://www.youtube.com/watch?v=i_GHFeXrRFY&list=PLVcyp7DP7MJxG2-QSUCi_Sqk2Xdzu1a7h", Label = "Red Planet (1994) Series on Youtube", Description = "Red Planet (1994) Series on Youtube", LinkType = LinkType.Video },
                new Link { BookTitle = "The Roads Must Roll", Url = "https://en.wikipedia.org/wiki/The_Roads_Must_Roll", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Rocket Ship Galileo", Url = "https://en.wikipedia.org/wiki/Rocket_Ship_Galileo", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Rolling Stones", Url = "https://en.wikipedia.org/wiki/The_Rolling_Stones_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Searchlight", Url = "https://en.wikipedia.org/wiki/Searchlight_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Sixth Column", Url = "https://en.wikipedia.org/wiki/Sixth_Column", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Sky Lift", Url = "https://en.wikipedia.org/wiki/Sky_Lift", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Solution Unsatisfactory", Url = "https://en.wikipedia.org/wiki/Solution_Unsatisfactory", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Space Cadet", Url = "https://en.wikipedia.org/wiki/Space_Cadet", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Space Jockey", Url = "https://en.wikipedia.org/wiki/Space_Jockey", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Star Beast", Url = "https://en.wikipedia.org/wiki/The_Star_Beast_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Starman Jones", Url = "https://en.wikipedia.org/wiki/Starman_Jones", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Starship Troopers", Url = "https://en.wikipedia.org/wiki/Starship_Troopers", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Stranger in a Strange Land", Url = "https://en.wikipedia.org/wiki/Stranger_in_a_Strange_Land", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Take Back Your Government: A Practical Handbook for the Private Citizen", Url = "https://en.wikipedia.org/wiki/Take_Back_Your_Government:_A_Practical_Handbook_for_the_Private_Citizen", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "A Tenderfoot in Space", Url = "https://en.wikipedia.org/wiki/A_Tenderfoot_in_Space", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "They", Url = "https://en.wikipedia.org/wiki/They_(Heinlein)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Time Enough for Love", Url = "https://en.wikipedia.org/wiki/Time_Enough_for_Love", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Time for the Stars", Url = "https://en.wikipedia.org/wiki/Time_for_the_Stars", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "To Sail Beyond the Sunset", Url = "https://en.wikipedia.org/wiki/To_Sail_Beyond_the_Sunset", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Tomorrow, the Stars", Url = "https://en.wikipedia.org/wiki/Tomorrow,_the_Stars", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Tramp Royale", Url = "https://en.wikipedia.org/wiki/Tramp_Royale", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Tunnel in the Sky", Url = "https://en.wikipedia.org/wiki/Tunnel_in_the_Sky", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Unpleasant Profession of Jonathan Hoag", Url = "https://en.wikipedia.org/wiki/The_Unpleasant_Profession_of_Jonathan_Hoag", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Variable Star", Url = "https://en.wikipedia.org/wiki/Variable_Star", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Waldo", Url = "https://en.wikipedia.org/wiki/Waldo_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Water Is for Washing", Url = "https://en.wikipedia.org/wiki/Water_Is_for_Washing", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "We Also Walk Dogs", Url = "https://en.wikipedia.org/wiki/%E2%80%94We_Also_Walk_Dogs", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Where To?", Url = "https://archive.org/stream/galaxymagazine-1952-02/Galaxy_1952_02#page/n13/mode/2up", Label = "Where To? (1952) on Archive.org", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Year of the Jackpot", Url = "https://en.wikipedia.org/wiki/The_Year_of_the_Jackpot", Label = "Wikipedia Link", LinkType = LinkType.Wiki }
            };

            return (books, links);
        }
    }
}
