import { StringMappingType } from "typescript";

export interface ServerError{
    statusCode: number;
    message: string;
    details: string;
}

