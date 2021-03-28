export interface Result<T> {
    succeeded: boolean;
    errors: string[];
    data: T;
}