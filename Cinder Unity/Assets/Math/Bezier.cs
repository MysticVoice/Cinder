using UnityEngine;
    public static class Bezier
    {
        public static float quadraticLerp(float p0, float p1, float p2, float t)
        {
            float first = Mathf.Lerp(p0, p1, t);
            float second = Mathf.Lerp(p1, p2, t);
            return Mathf.Lerp(first, second, t);
        }
        public static Vector2 quadraticLerp2D(Vector2 p0, Vector2 p1, Vector2 p2, float t)
        {
            float x = quadraticLerp(p0.x, p1.x, p2.x, t);
            float y = quadraticLerp(p0.y, p1.y, p2.y, t);
            return new Vector2(x, y);
        }

        public static float bezier(float p0, float p1, float p2, float p3, float t)
        {
            float first = quadraticLerp(p0, p1, p2, t);
            float second = quadraticLerp(p1, p2, p3, t);
            return Mathf.Lerp(first, second, t);
        }

        public static Vector2 bezier2D(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, float t)
        {
            float x = bezier(p0.x, p1.x, p2.x, p3.x, t);
            float y = bezier(p0.y, p1.y, p2.y, p3.y, t);
            return new Vector2(x, y);
        }
    }
