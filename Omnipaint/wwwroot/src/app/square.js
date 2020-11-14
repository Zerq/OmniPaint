export class Square {
    constructor(ctx) {
        this.ctx = ctx;
    }
    draw(x, y, z) {
        this.ctx.fillRect(z * x, z * y, z, z);
    }
}
//# sourceMappingURL=square.js.map