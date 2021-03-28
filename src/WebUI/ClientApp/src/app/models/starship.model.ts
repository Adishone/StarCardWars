import { CrewMember } from "./crew-member.model";

export interface Starship {
    id: number;
    name: string;
    mass: number;
    imagePath: string;
    crewMembers: CrewMember[];
}