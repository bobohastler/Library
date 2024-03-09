using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.Processing;

namespace Library.Helpers;

public static class ImageWorker
    {
        /// <summary>
        /// Збереження фото в папку
        /// </summary>
        /// <param name="url">Адреса фото в мережі</param>
        /// <param name="folderName">Назва папки</param>
        /// <param name="imageName">Назва фото без розширення</param>
        /// <returns>Повертаємо назву фото</returns>
        public static string? ImageSave(string url, string folderName, string? imageName = null)
        {
            try // ловимо помилки
            {
                using HttpClient client = new HttpClient(); // HTTP клієнт для скачування фото
                var response = client.GetAsync(url).Result; // скачуємо фото
                if (response.IsSuccessStatusCode) // якщо все добре
                {
                    //список байт фото
                    byte[] imageBytes = response.Content.ReadAsByteArrayAsync().Result; 
                    int []sizes = [50,150,300,600,1200]; //розмір фото, яке буде зберігатися
                    //Рандомна навза, яка не може повторится при генерації
                    string fileName = imageName ?? Guid.NewGuid() + ".webp";
                    var dir = Path.Combine(Directory.GetCurrentDirectory(), "images", folderName); // шлях папки
                    if (!Directory.Exists(dir)) // якщо папка не існує
                    {
                        Directory.CreateDirectory(dir); // створюємо її
                    }
                    foreach (var size in sizes) // для кожного розміру робимо
                    {
                        var outPath = Path.Combine(dir, size+"_"+fileName); // шлях і назва файла
                        using var image = Image.Load(imageBytes); // завантажуємо дані фото в буфер
                        image.Mutate(x =>
                        {
                            x.Resize(new ResizeOptions
                            {
                                Size = new Size(size, size),
                                Mode = ResizeMode.Max
                            });
                        }); // змінюємо розмір
                        using var ms = new MemoryStream();
                        image.Save(ms, new WebpEncoder());
                        var bytesOut = ms.ToArray();
                        File.WriteAllBytes(outPath, bytesOut); // зберігаємо
                    }
                    return fileName; // повертаємо базову назву фото
                }
                // якщо не вийшло скачати фото
                Console.WriteLine("Запит по фото пройшов із проблемой {0}", response.StatusCode);
            }
            catch (Exception ex) // ловимо всі виключення
            {
                Console.WriteLine("Помилка збереження фото {0}", ex.Message);
            }
            return null; // якщо все погано, повертаємо null
        }
    }