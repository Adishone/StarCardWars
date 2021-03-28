import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Result } from '../models/result.model';
import { StarshipFightResult } from '../models/starship-fight-result.model';

@Injectable({
  providedIn: 'root'
})
export class StarshipService {

  constructor(private httpClient: HttpClient) { }

  public getStarshipFightResult(): Observable<Result<StarshipFightResult>> {
    return this.httpClient.get<Result<StarshipFightResult>>('localhost:44312/api/StarshipFight');
  }
}
