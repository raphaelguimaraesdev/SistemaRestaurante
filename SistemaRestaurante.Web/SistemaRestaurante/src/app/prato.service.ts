import { Injectable }     from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs';
import {map, catchError} from "rxjs/operators";
import { Prato } from './shared/Prato.model'


@Injectable()
export class PratoService {
  private endereco = 'http://localhost:59740/api/Prato';
  constructor(private http: Http) { }

  public ObtenhaPrato(nome: string) {
       let prato = this.http.get(this.endereco)
       .pipe(
        map((res: Response) => res.json()),
        catchError((error:any) => Observable.throw(error.json.error || 'Server error'))
      );

   return prato;

  }

}
