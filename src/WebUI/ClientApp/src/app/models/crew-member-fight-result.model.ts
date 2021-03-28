import { CrewMember } from "./crew-member.model";

export interface CrewMemberFightResult {
    firstPlayerCrewMember: CrewMember;
    secondPlayerCrewMember: CrewMember;
    fightProperty: string;
    firstPlayerOverallScore: number;
    secondPlayerOverallScore: number;
    isDraw: boolean;
}