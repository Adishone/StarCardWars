import { Starship } from "./starship.model";

export interface StarshipFightResult {
    firstPlayeStarship: Starship;
    secondPlayeStarship: Starship;
    fightProperty: string;
    firstPlayerOverallScore: number;
    secondPlayerOverallScore: number;
    isDraw: boolean;
}