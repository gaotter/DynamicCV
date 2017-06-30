import {IProjects} from './i-projects';

export interface IEntries {
    id:number,
    title:string,
    from:string,
    fromAsUtcJsTicks:number
    to:string,
    toAsUtcJSTicks:number,
    contentText:string,
    areas: any[],
    projects:IProjects[]
}