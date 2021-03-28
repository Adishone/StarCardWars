import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CrewMemberFightResult } from '../models/crew-member-fight-result.model';
import { Result } from '../models/result.model';

@Injectable({
  providedIn: 'root'
})
export class CrewMemberService {

  constructor(private httpClient: HttpClient) { }

  public getCrewMembersFightResult(): Observable<Result<CrewMemberFightResult>> {
    return this.httpClient.get<Result<CrewMemberFightResult>>('https://localhost:44312/api/CrewMemberFight?fightProperty=strength');
  }
}
