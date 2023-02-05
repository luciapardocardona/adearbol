public class Dialogs
{
    public Asf questions;
    public Asf playerAnswers;
    public Asf npcAnswers;
}

public class Asf
{
    public People positive;
    public People negative;
}

public class People
{
    public string friend;
    public string family;
    public string mole;
}


public class QuestionsConstants
{
    public static Dialogs day1 = new Dialogs
    {
        questions = new Asf
        {
            positive = new People
            {
                friend = "¡Heeey! ¿Qué paasaa, baabyy? ¿Cómo te trata la viaa? He estao unos días fuera del pueblo y... buaf, han sio unos días chunguillos, para darle al coco y esas cosas... Y se ma ocurrio algo que nos daría LA VIDA, ¿me entiendes? Y yo sé que tú me apoyas hasta la muerte... ¿e o no e?",
                family = "¡Buenos días, cariño! ¿Qué tal has dormido? Aquí tienes tu desayuno. Hoy he hecho tostaditas con bellota. Si no tienes nada que hacer, deberías acercarte al pueblo. ¡Hoy hay un jaleo enorme! Y mira que este pueblo es tranquilo... Ay... Me encanta este pueblo. ¿A ti te gusta?",
                mole = "¡Hola, Chulo! ¿Puedo llamarte así? ¿Chulo? A mí me suena de fábula. Soy Topo Sandoquín, de la famosa familia Sandoquín... ¡Sí, sí, los hoteles! Acabo de llegar al pueblo en busca de un lugar dónde construir un gran proyecto, pero necesitaría un poco de apoyo... Estoy seguro de que a alguien joven y enérgico como tú le flipará. ¿Te gustaría que te contase más sobre mi idea?"
            },
            negative = new People
            {
                friend = "¡Heeey! ¿Qué paasaa, baabyy? ¿Cómo te trata la viaa? He estao unos días fuera del pueblo y... buaf, han sio unos días chunguillos, para darle al coco y esas cosas... Y se ma ocurrio algo que nos daría LA VIDA, ¿me entiendes? Y yo sé que tú me apoyas hasta la muerte... ¿e o no e?",
                family = "¡Buenos días, cariño! ¿Qué tal has dormido? Aquí tienes tu desayuno. Hoy he hecho tostaditas con bellota. Si no tienes nada que hacer, deberías acercarte al pueblo. ¡Hoy hay un jaleo enorme! Y mira que este pueblo es tranquilo... Ay... Me encanta este pueblo. ¿A ti te gusta?",
                mole = "¡Hola, Chulo! ¿Puedo llamarte así? ¿Chulo? A mí me suena de fábula. Soy Topo Sandoquín, de la famosa familia Sandoquín... ¡Sí, sí, los hoteles! Acabo de llegar al pueblo en busca de un lugar dónde construir un gran proyecto, pero necesitaría un poco de apoyo... Estoy seguro de que a alguien joven y enérgico como tú le flipará. ¿Te gustaría que te contase más sobre mi idea?"
            }
        },
        playerAnswers = new Asf
        {
            positive = new People
            {
                friend = "",
                family = "",
                mole = ""
            },
            negative = new People
            {
                friend = "",
                family = "",
                mole = ""
            }
        },
        npcAnswers = new Asf
        {
            positive = new People
            {
                friend = "¡Eeeh, ahí está mi hermane! Bua, ahora me da hasta cosa contártelo por si me dices que soy un locuelo.",
                family = "¡Claro que sí, mi niño! Te quiero mucho, ¡muuuacks!",
                mole = "¡Genial! Sabía que encontraría a alguien que me apoyase. Este pueblo me da muy buenas vibras... "
            },
            negative = new People
            {
                friend = "Jajaja, no me seas gallina... En fin, date una vuelta que se te quite la tontería y vuelves a verme, ¿va?",
                family = "Mmm, bueno, estoy segura de que cambiarás de idea con el pasito del tiempo. Aún eres muy joven para apreciar la tranquilidad...",
                mole = "Anda, qué pena... Creí que había encontrado a un autóctono tan ambicioso como yo... Bueno, si cambias de idea, vuelve a verme. Pero te aviso de que estás perdiendo una oportunidad de oro."
            }
        },
    };

    public static Dialogs day2 = new Dialogs
    {
        questions = new Asf
        {
            positive = new People
            {
                friend = "¡Holaaaa, chatii! ¿Cómo va eso? Va venga, te lo cuento. No me hago más de rogar. ¿Y si montamos una banda de rock? Tú a la batería, yo a la guitarra... Bueno, y ya encontraremos a alguien más para completar la banda. Buah... Haríamos giras, viajaríamos por el mundo... ¿No te flipa?",
                family = "¡Buenos días, cariñín! ¿Cómo has dormido? Hoy para desayunar tenemos bellota frita. ¿Has oído lo que se rumorea por el pueblo? Al parecer, ha llegado alguien de fuera que quiere construir no se qué edificio en el pueblo. No me gusta mucho cuando construyen cosas nuevas en el pueblo... y mucho menos si se trata de alguien que no vive aquí porque seguro que no se preocupa por las necesidades de nosotros y los habitantes del pueblo. ¿Qué opinas tú?",
                mole = "¡Buenos días, leyenda! Me alegra verte por aquí. El caso es que quería contarte lo de mi proyecto con más detalle. Me gustaría construir una torre en el pueblo con algunas tiendecillas y un hotelilllo, nada muy ostentoso, ya sabes, para reavivar la economía y el turismo. ¡Todos salimos ganando! ¿Qué opinas? ¿Tengo tu apoyo?"
            },
            negative = new People
            {
                friend = "¡Holiiis! Va venga, te lo cuento. No me hago más de rogar. ¿Y si montamos una banda de rock? Tú a la batería, yo a la guitarra... Bueno, y ya encontraremos a alguien más para completar la banda. Buah... Haríamos giras, viajaríamos por el mundo... ¿No te flipa?",
                family = "¡Buenos días! Hoy para desayunar tenemos bellota al vapor. ¿Has oído lo que se rumorea por el pueblo? Al parecer, ha llegado alguien de fuera que quiere construir no se qué edificio en el pueblo. No me gusta mucho cuando construyen cosas nuevas en el pueblo... y mucho menos si se trata de alguien que no vive aquí porque seguro que no se preocupa por las necesidades de nosotros y los habitantes del pueblo. ¿Qué opinas tú?",
                mole = "Hola de nuevo. A ver, porque creo que ayer no empezamos con muy buen pie quería contarte lo de mi proyecto con más detalle. Me gustaría construir una torre en el pueblo con algunas tiendecillas y un hotelilllo, nada muy ostentoso, ya sabes, para reavivar la economía y el turismo. ¡Todos salimos ganando! ¿Qué opinas? ¿Tengo tu apoyo?"
            }
        },
        playerAnswers = new Asf
        {
            positive = new People
            {
                friend = "",
                family = "",
                mole = ""
            },
            negative = new People
            {
                friend = "",
                family = "",
                mole = ""
            }
        },
        npcAnswers = new Asf
        {
            positive = new People
            {
                friend = "¿A que sí? Se me ocurrió a mí solito, ¿eh? Estaba en la cama comiendo techo y de repente lo vi... Los focos, el escenario, el público coreándonos...",
                family = "Me alegro de que lo entiendas. Me deja más tranquile saber que esta familia siempre estará en buenas manos.",
                mole = "¡Muchísimas gracias! Espero que no te importe, pero había pensado en ubicar el novedoso edificio ahí, donde está ese árbol, así estaría lo suficientemente lejos para que las obras no molesten a nadie del pueblo, y seguro que así nos apoyan."
            },
            negative = new People
            {
                friend = "Pero si es una idea bestial, colega. Es que estás anticuae, hermane. Pareces mi abueleee.",
                family = "Bueno, ojalá tengas razón. Podría ser un lavado de cara al pueblo...",
                mole = "¿Y eso? ¡Pero si lo tiene todo! De hecho, si os interesase, podríamos llegar a algún acuerdo económico que os beneficiase también a ti y a tu familia. Eso si os interesase, claro..."
            }
        },
    };

    public static Dialogs day3 = new Dialogs
    {
        questions = new Asf
        {
            positive = new People
            {
                friend = "¡Hola, caracola! Qué movida, hermano. Acaban de decirme que necesitamos un representante. Yo no puedo serlo, que tengo movidas con el banco. ¿Y si ponemos tu nombre en el formulario y a pastar?",
                family = "¡Buenisísimos días, chiquitín! Hoy me he levantado un poquito antes y he hecho setas con bellotitas para desayunar. Mmm... Hace mucho que no comemos ensaladita, ¿no crees? ¿Por qué no te acercas a la tienda del pueblo y compras nueces para que podamos hacerla para almorzar?",
                mole = "¡Hey, hey! ¿Te gustaría ayudarme con una cosita para acelerar las obras del proyectito que te conté ayer? Es que necesito que alguien me ayude con un papeleo del Ayuntamiento y sé que a la gente de aquí os van a hacer más caso que a un forastero como yo. ¿Te importaría llevarle estos papeles al alcalde por mí?"
            },
            negative = new People
            {
                friend = "Chilindróooon, que me tienes abandonao. Qué movida, hermano. Acaban de decirme que necesitamos un representante. Yo no puedo serlo, que tengo movidas con el banco. ¿Y si ponemos tu nombre en el formulario y a pastar?",
                family = "Buenos días. Ayer se me olvidó ir a comprar y he hecho el desayuno con lo poquito que quedaba. Estoy segure de que mañana será mejor. Mmm... Hace mucho que no comemos ensaladita, ¿no crees? ¿Por qué no te acercas a la tienda del pueblo y compras nueces para que podamos hacerla para almorzar?",
                mole = "Oye, ¿estás liado? Es que necesito que alguien me ayude con un papeleo del Ayuntamiento y sé que a la gente de aquí os van a hacer más caso que a un forastero como yo. ¿Te importaría llevarle estos papeles al alcalde por mí?"
            }
        },
        playerAnswers = new Asf
        {
            positive = new People
            {
                friend = "",
                family = "",
                mole = ""
            },
            negative = new People
            {
                friend = "",
                family = "",
                mole = ""
            }
        },
        npcAnswers = new Asf
        {
            positive = new People
            {
                friend = "¡Flipa! ¡Vamos a ser les próximes Green May!",
                family = "¡Qué bien, qué ganas de comer ensaladita! Esta vez innovaré con la receta y le añadiré un poquito de maíz, que le dé un toque dulcecito.",
                mole = "¡Gracias, majo! Poquito a poco y juntos, conseguiremos darle la importancia que merece a un enclave como este. ¡Ah! Se me olvidaba. Me he enterado de que vives con tu familia en el árbol que teníamos pensado talar... Si sigues conmigo, podemos llegar a un acuerdo para que tu familia y tú no os quedéis sin casa. ¡Solo tienes que apoyarme en todo!"
            },
            negative = new People
            {
                friend = "Pss, tampoco te me vayas a rajar ahora, ¿eh? Que ya he contratao hasta el chófer pa la caravana.",
                family = "Pero bueno, ¿cómo que no? Tendrás que ayudar un poquito en casa. ¿Qué te crees? ¿Que esto es un hotel? No somos tus sirvientes. Para una cosa que te pido...",
                mole = "¡Vaya mala sombra tienes! Ni un favor puedes hacerme. Vaya con la gente de este pueblo. No os merecéis el esfuerzo y la inversión que estoy haciendo para vosotros."
            }
        },
    };

    public static Dialogs day4 = new Dialogs
    {
        questions = new Asf
        {
            positive = new People
            {
                friend = "¡Hola, mequetrefe! Hay una pregunta que llevo pexá tiempo planteándome y me ralla cantidubi... Si tuvieras que elegir entre vivir en un peazo rascielos en la big city, o morirte del asco con los viejos del pueblo en este pozo... Te decantarías por la big city, ¿no?",
                family = "¡Buenos días, florecilla! Hoy para desayunar he ido a por churritos con cremita de bellota. Por cierto, últimamente pasas mucho tiempo fuera... Estoy preocupade por ti. El otro día te vi tirar un pañuelito al suelo. Nuestra familia siempre ha sido fiel defensora de la preservación del bosque, ¿no te parece?",
                mole = "Vaya... Hola... Siento que me veas tan alicaído, es que no estoy recibiendo mucho apoyo de parte del pueblo para mi proyecto... y mira que lo hago por el bien de toda esta gente y por los extranjeros interesados en vivir la cultura del pueblo... ¿a ti te gusta viajar?"
            },
            negative = new People
            {
                friend = "¡Eh! ¡Cabeza bellota! Hay una pregunta que llevo pexá tiempo planteándome y me ralla cantidubi... Si tuvieras que elegir entre vivir en un peazo rascielos en la big city, o morirte del asco con los viejos del pueblo en este pozo... Te decantarías por la big city, ¿no?",
                family = "Por fin te levantas. Hoy no me ha dado tiempo a prepararte el desayuno... Coge algo de dinero y sales a desayunar fuera. Por cierto, últimamente pasas mucho tiempo fuera... Estoy preocupade por ti. El otro día te vi tirar un pañuelito al suelo. Nuestra familia siempre ha sido fiel defensora de la preservación del bosque, ¿no te parece?",
                mole = "Mira, sé que ayer no estabas muy receptivo, todos tenemos días malos, Es que no estoy recibiendo mucho apoyo de parte del pueblo para mi proyecto... y mira que lo hago por el bien de toda esta gente y por los extranjeros interesados en vivir la cultura del pueblo... ¿a ti te gusta viajar?"
            }
        },
        playerAnswers = new Asf
        {
            positive = new People
            {
                friend = "",
                family = "",
                mole = ""
            },
            negative = new People
            {
                friend = "",
                family = "",
                mole = ""
            }
        },
        npcAnswers = new Asf
        {
            positive = new People
            {
                friend = "¡YIII-JAA! La big city es lo más. Prepárate. Nos espera una vida de rockstars.",
                family = "Exacto, el bosque es nuestro amigo. Nosotres cuidamos de el bosque, y él cuida de nosotres. Todos le debemos mucho.",
                mole = "¡Claro que sí! ¿Cómo no te va a gustar? Visitar sitios nuevos, hacerse fotitos para fardarle a tus amigos, probar chocolates de diferentes orígenes, por que eso es lo que coméis vosotros, ¿no? Claro, sí, chocolate. Además de sacar estereotipos de cada pueblo, como las hurracas... ¡Qué agarradas son, las malnacidas! ¡Que yo tengo amigas hurracas, eh! Jajajaja... Tú ya me entiendes."
            },
            negative = new People
            {
                friend = "Sí, claro, y ahora me dirás que también prefieres el tocino a la velocidad. Vete a casa y mañana me dices.",
                family = "¿Cómo dices? No vuelvas a decir algo así en esta casa. Y menos aún en el pueblo. Alguien podría oírte, y quién sabe qué podrían hacernos.",
                mole = "Tus razones tendrás, supongo. Tampoco te quiero imponer mi opinión, pero me da a mí que tú no has salido mucho del pueblo, ¿verdad? Espero que salgáis pronto tu familia y tú."
            }
        },
    };

    public static Dialogs day5 = new Dialogs
    {
        questions = new Asf
        {
            positive = new People
            {
                friend = "¡Cómo está mi roedor favorito! Ya he metio to mi equipaje en la caravana, ya tenemos al chófer, obviamente, porque yo paaaso de conducir.",
                family = "¡Buenos días, mi amor! Hoy he hecho huevos de codorniz con trufitas silvestres y esencia de bellota fresca para desayunar, ¡tus preferidos! Al parecer, el señor Mole piensa construir una torre en algún lugar del pueblo. Deberíamos pararle los pies. No podrá acabar con nuestro hogar bajo ningún concepto. ¿Te unirás a nosotres en su contra?",
                mole = "Muchas gracias por venir a verme. Estoy desesperado. Este pueblo está lleno de inconscientes... ¿Cómo puede ser que a nadie le guste mi ideaza? Pero si mi torre va a quedar monísima. No tiene ni una pega. Dime, ¿podré confiar en ti para el resto de las obras de la torre?"
            },
            negative = new People
            {
                friend = "¡Loco! Ya he metio to mi equipaje en la caravana, ya tenemos al chófer, obviamente, porque yo paaaso de conducir.",
                family = "... Al parecer, el señor Mole piensa construir una torre en algún lugar del pueblo. Deberíamos pararle los pies. No podrá acabar con nuestro hogar bajo ningún concepto. ¿Te unirás a nosotres en su contra?",
                mole = "No me lo puedo creer. Estoy desesperado. Este pueblo está lleno de inconscientes... ¿Cómo puede ser que a nadie le guste mi ideaza? Pero si mi torre va a quedar monísima. No tiene ni una pega. Dime, ¿podré confiar en ti para el resto de las obras de la torre?"
            }
        },
        playerAnswers = new Asf
        {
            positive = new People
            {
                friend = "",
                family = "",
                mole = ""
            },
            negative = new People
            {
                friend = "",
                family = "",
                mole = ""
            }
        },
        npcAnswers = new Asf
        {
            positive = new People
            {
                friend = "¡NIQUELAO! Mete la batería donde sea que se guarden las baterías, dile bye a tus progenitores y vámonos ¡YA!",
                family = "Ayy... Perdona, me he... dejado llevar. Te quiero mucho, mi niñe... Estoy muy orgullose de ti. Permanezcamos unides como una familia.",
                mole = "Sabía que lo comprenderías y me apoyarías. Te estaré agradecido para siempre. Vamos a hacer esto juntos. Por fin mi padre podrá sentirse orgulloso de mí."
            },
            negative = new People
            {
                friend = "No se te ve con muchas ganas de venirte. SI quieres quedarte en el pueblo, dímelo y ya, que tampoco me voy a cabrear...",
                family = "No tengo palabras. Me rompes el corazón.... Por favor, desaparece de mi vista ahora mismo. Algún día te arrepentirás de lo que acabas de decir.",
                mole = "¿En serio? Claro, era de esperar. Nadie es de fiar por estos lares así que tendré que apañármelas yo solito. Me cansé de hablar contigo. Que te vaya bien la vida."
            }
        },
    };

}
