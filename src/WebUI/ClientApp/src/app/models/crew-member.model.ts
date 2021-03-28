import { Starship } from "./starship.model";

export interface CrewMember {
    id: number;
    firstName: string;
    lastName: string;
    strength: number;
    agility: number;
    intellect: number;
    imagePath: string;
    starship: Starship;
}