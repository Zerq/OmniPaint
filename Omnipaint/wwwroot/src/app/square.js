export class Square {
    constructor(ctx) {
        this.ctx = ctx;
    }
    draw(x, y, z) {
        this.ctx.fillRect(z * x, z * y, z, z);
    }
}
2;
//# sourceMappingURL=square.js.map