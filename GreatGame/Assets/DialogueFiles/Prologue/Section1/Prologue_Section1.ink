EXTERNAL Sequence(x)


== Astrakan00 ==
Port of Astrakan is brustling with people. Blue sky and sea expand endlessly. Muslims, Russians, and even British merchants are trading for the hopes of great fortune. You gently take out a paper out from your pocket. It's Tsar Nicholas I's Imperial order.

    *   [Read the order.]
        "Prince Aleksei Bekovski. Your mission is to travel to Khiva and offer Khan of Khiva our alliance. Khiva is a strategic region for my country to bring riches from British India. Failure is not an option. Bring glory to motherland."
    *   *   [Put the order back into your pocket]
        As you finish reading the order, your lieutenant, Major Frankenburg, approaches you. He stands at attention and salutes, "Prince Bekovski! Men and supplies are ready. 4000 men and 500 horses. We depart at your order, your highness."
    *   *   *   [(Salute back.)"Good work major."]  -> Astrakan02_01
    *   *   *   [(Don't salute back.)"That took longer than I expected."]  -> Astrakan02_02

    
== Astrakan02_01 ==
He lowers his salute. Standing at ease, he continues, "Just doing my duty, your highness." But behind his firm voice, you sense an uneasiness.

    *   ["You seem concerned."] 
        -> Astrakan03
    *   "Something you want to share major?" 
        -> Astrakan03
    
== Astrakan02_02 ==
Keeping his salute, he speaks, "My apologies, your highness. I take full responsibility for my lateness." But behind his firm voice, you sense an uneasiness.

    *   [Salute back.] "You seem concerned." 
        -> Astrakan03
    *   [Salute back.] "Something you want to share major?" 
        -> Astrakan03

== Astrakan03 ==
With the moment of hesitation, he speaks, "With your permission, your highness... Many men are voicing their concerns... Savage turcoman bandits, the endless desert, sand storms... We will be raided day and night. And the extreme heat will cause diseases among men."

    *   "We are soldiers. It is our duty to execute Tsar's will."
        -> Astrakan04
    *   "As a soldier of the Imperium, you will not flash your weakness in front me." 
        -> Astrakan04

== Astrakan04 ==
"If that is your will, we will follow." Major then heads back to his men. You look up at your flag ship, Imperator Aleksandr. 110-gun, made of oak trees, this juggernaught seems invincible.

    *   Board the ship. Set sail for Krasnovodsk. Sequence("SetActive(Panel_Map)") 
        -> END








== function Sequence(x) ==
~ return 1